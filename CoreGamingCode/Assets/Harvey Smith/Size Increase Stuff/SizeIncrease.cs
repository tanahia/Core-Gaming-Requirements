using UnityEngine;


public class SizeIncrease: MonoBehaviour
{
    
    TMPro.TextMeshPro m_TextMeshPro;

   
 

    // Start is called before the first frame update
    void Start()
    {
        
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        if (m_TextMeshPro == null)
        {
            m_TextMeshPro = GetComponent<TMPro.TextMeshPro> ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Code here increases size
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_TextMeshPro.fontSize += 1;
        }
        //Code here decreases size
        if (Input.GetKeyDown(KeyCode.Return))
        {
            m_TextMeshPro.fontSize -= 1;
        }
        
        //Code here prevents text from distorting from a 0 or minus figure
        if (m_TextMeshPro.fontSize <= 1)
        {
            m_TextMeshPro.fontSize = 1;
        }
        //Code here prevents text from distorting from a size too big that changes the text
        if (m_TextMeshPro.fontSize >= 19)
        {
            m_TextMeshPro.fontSize = 19;
        }
    }
}
