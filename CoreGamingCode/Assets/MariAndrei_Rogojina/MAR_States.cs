using System;
using UnityEngine;

public class MAR_States : MonoBehaviour
{
    // A Stat machine requires a set of describing behaviours of NPCs

    // Assumption: Script below must be attached to NPC
    SF_CharacterMovement characterMovementControlScript;
    Vector3 centerPositionOfPatrolZone;
    MAR_TimerScript walkTimer;

    enum NPCBehaviours { Patrol, Chase, Attack }

    enum NPCTransitions { See_Enemy, Within_Attack_Range, Nothing }

    enum Actions { SetupWAlk, Walk, EndWalk }

    NPCBehaviours isCurrently = NPCBehaviours.Patrol;
    NPCTransitions worldState = NPCTransitions.Nothing;
    Actions action = Actions.Walk;

    float AggroDetectionRadius = 5;
    float BufferSpace = 1;
    private float patrolSpeed;

    private NPCTransitions senseSurroudings()
    {
        // TO see an enemy we could check "in front" of the character and determine if anything there is an enemy

        Collider[] allThingsInFrontOf = Physics.OverlapSphere(transform.position + (BufferSpace+AggroDetectionRadius) * transform.forward, AggroDetectionRadius);

        foreach (Collider c in allThingsInFrontOf)
        {
            if (isEnemy(c)) return NPCTransitions.See_Enemy;
        }
        return NPCTransitions.Nothing;
    }

    void Start()
    {

        characterMovementControlScript = GetComponent<SF_CharacterMovement>();
        if (characterMovementControlScript != null ) { print("warning Missing Char MOvement Script"); }
    }
private bool isEnemy(Collider c)
    {
        return true;
    }

    private NPCTransitions senseSurroundings()
    {
        return NPCTransitions.Nothing;
    }

    // Update is called once per frame
    void Update()
    {

        // Sensing Stage
        worldState = senseSurroundings();

        // Thinking Stage
        switch (isCurrently) { };

        // Action Stage

        switch (isCurrently)
        {
            case NPCBehaviours.Patrol:
                // This NPC can patrol randomly within a given radius of a given point
                switch (action)
                {
                    case Actions.SetupWAlk:

                        walkTimer.InitialiseTimer(5);
                        walkTimer.StartTimer();
                        action = Actions.Walk;

                        break;
                }
                walkTimer = gameObject.AddComponent<MAR_TimerScript>();
                

                if (walkTimer.GetTimeRemaining() > 0)
                    characterMovementControlScript.moveForward(patrolSpeed);
                else
                {
                    characterMovementControlScript.transform.rotation = 
                        Quaternion.LookRotation(pickRandomDirection());
                }




                    // Walk forward for a specific amount of time. Turn and repeat
                    // Check if is outside of permitted range


                    break;

            case NPCBehaviours.Chase:

                break;

            case NPCBehaviours.Attack:

                break;

            default:

                break;
        }


        switch (isCurrently)
        {
            case NPCBehaviours.Patrol:
                // Deal with all situations for exiting (or not) Patrol state
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
                // Deal with all situations for exiting (or not) Chase state

                break;
            case NPCBehaviours.Attack:
                // Deal with all situations for exiting (or not) Attack state
                break;

            default:

                break;
        }
    }

    private Vector3 pickRandomDirection()
    {
        throw new NotImplementedException();
    }

    public void setCenterZonePosition(Vector3 centerZonePosition)
    {
        centerPositionOfPatrolZone = centerZonePosition;
    }
}
