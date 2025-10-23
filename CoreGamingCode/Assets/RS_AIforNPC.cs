using System;
using UnityEditor;
using UnityEngine;

public class RS_AIforNPC : MonoBehaviour
{
    /// <summary>
    ///  A State Machine requires a set of States describing behaviours of NPC
    /// </summary>
    /// 

    // Assumption:  Script below must be attached  to NPC  
    SF_CharacterMovement characterMovementControlScript;
    Vector3 centerPositionofPatrolZone;
    MAR_TimerScript walkTimer;

    enum NPCBehaviours { Patrol, Chase, Attack }

    enum NPCTransitions { See_Enemy, Within_Attack_Range, Nothing}



    enum Actions { SetupWalk, Walk, EndWalk}
    Actions action = Actions.SetupWalk;

    NPCBehaviours isCurrently = NPCBehaviours.Patrol;
    NPCTransitions worldState = NPCTransitions.Nothing;

    float AggroDetectionRadius = 5;
    float bufferForDetrection = 1;
    private float patrolSpeed;

    void Start()
    {

        characterMovementControlScript = GetComponent<SF_CharacterMovement>();
        if (characterMovementControlScript == null)
        {
            print("Warning Missing Char Movement Script");
        }

    }

    private NPCTransitions senseSurroundings()
    {
        // To see an enemy we could check "in front" of the character and determine if anything there is an enemy

        Collider[] allThingsInFrontOf = Physics.OverlapSphere(transform.position + (bufferForDetrection + AggroDetectionRadius) * transform.forward, AggroDetectionRadius);

        foreach (Collider c in allThingsInFrontOf)
        {
            if (isEnemy(c)) return NPCTransitions.See_Enemy;
        }



        return NPCTransitions.Nothing;
    }

    private bool isEnemy(Collider c)
    {
        //  ??????

        return true;
    }

    // Update is called once per frame
    void Update()
    {

        // Sensing Stage
        worldState = senseSurroundings();


        // Thinking Stage

        switch (isCurrently)
        {
            case NPCBehaviours.Patrol:
                // deal with all situations for exiting (or not) patrol state
                switch (worldState)
                {
                    case NPCTransitions.See_Enemy:
                        isCurrently = NPCBehaviours.Chase;
                        break;

                    case NPCTransitions.Within_Attack_Range:
                        isCurrently = NPCBehaviours.Attack;

                        break;


                    default:

                        break;


                }


                break;

            case NPCBehaviours.Chase:
                // deal with all situations for exiting (or not) Chase state
                break;

            case NPCBehaviours.Attack:
                // deal with all situations for exiting (or not) Attack state

                break;

            default:


                break;


        }


        // Action Stage

        switch(isCurrently)
        {
            case NPCBehaviours.Patrol:
                // This NPC can patrol randomly within a given radius of a given point

                switch (action)
                {
                    case Actions.SetupWalk:
                        walkTimer.InitialiseTimer(5);
                        walkTimer.StartTimer();
                        action = Actions.Walk;
                        break;

                    case Actions.Walk:



                        if (walkTimer.GetTimeRemaining() > 0)
                            characterMovementControlScript.moveForward(patrolSpeed);
                        else
                        {
                            characterMovementControlScript.transform.rotation = 
                                Quaternion.LookRotation(pickRandomDirection());
                        }


                            break;

                }
                // Walk forward for a specific amount of time. turn and repeat
                walkTimer = gameObject.AddComponent<MAR_TimerScript>();


                // Check if is outside of permitted range;


                break; ;

            case NPCBehaviours.Chase:

                break;
            case NPCBehaviours.Attack:

                break;
            default: break;

        }





    }

    private Vector3 pickRandomDirection()
    {
        throw new NotImplementedException();
    }

    public void setCentreZonePosition(Vector3 centreZonePosition)
    {
        centerPositionofPatrolZone = centreZonePosition;
    }
}
