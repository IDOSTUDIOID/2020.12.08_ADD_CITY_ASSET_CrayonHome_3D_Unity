using UnityEngine;

public class Move : MonoBehaviour
{
    
    public GameObject[] ch = new GameObject[6]; // 캐릭터
   /*
    public GameObject[] choco = new GameObject[5]; // 초코비 하나
    public GameObject[] box = new GameObject[2]; // 초코비 박스
    
    public GameObject[] breakfast = new GameObject[13]; // 아침밥
    
    public GameObject[] dogFood = new GameObject[1];
    public GameObject[] door = new GameObject[5];
    
    public GameObject[] dog = new GameObject[6];
    
       
    // 흰둥이 시야 밥먹기
    public GameObject[] eatDog = new GameObject[3];
    public GameObject[] dogFood = new GameObject[3];
    public GameObject[] homeBack = new GameObject[2];
    

    public GameObject[] puding = new GameObject[10];
    */
    public GameObject[] bus = new GameObject[4];

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * 20.0f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 20.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 20.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 20.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.Z)) // 현관내려가기
        {
            ch[0].SetActive(false);
            ch[1].SetActive(true);
        }
        if (Input.GetKey(KeyCode.X)) // 문열기
        {
            bus[0].SetActive(false); // 문열기 - 문
            bus[1].SetActive(false); // 문열기 - 고리
        }
        if (Input.GetKey(KeyCode.C)) // 입구문열기
        {
            bus[2].SetActive(false); // 문열기 - 문
        }
        if (Input.GetKey(KeyCode.V)) // 버스문열기
        {
            bus[3].SetActive(false); // 문열기 - 문
        }
        if (Input.GetKey(KeyCode.B)) // 계단올라가기
        {
            ch[1].SetActive(false);
            ch[2].SetActive(true);
        }
        if (Input.GetKey(KeyCode.N)) // 계단올라가기
        {
            ch[2].SetActive(false);
            ch[3].SetActive(true);
        }
        if (Input.GetKey(KeyCode.M)) // 버스안걸어가는짱구
        {
            ch[3].SetActive(false);
            ch[4].SetActive(true);
        }
        if (Input.GetKey(KeyCode.K)) // 버스앉기
        {
            ch[4].SetActive(false);
            ch[5].SetActive(true);
        }
        if (Input.GetKey(KeyCode.L)) // 문닫기
        {
            bus[3].SetActive(true);
        }

        /*
        else if (Input.GetKey(KeyCode.Z)) // 올라가기
        {
            ch[0].SetActive(false);
            ch[1].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.X)) // 앉기
        {
            ch[1].SetActive(false);
            ch[2].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.C)) // 숟가락들기
        {
            puding[0].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.V)) // 푸딩먹기1
        {
            puding[1].SetActive(false); // 윗시럽
            puding[2].SetActive(false); // 앞시럽
            puding[3].SetActive(false); // 푸딩
        }
        else if (Input.GetKey(KeyCode.B)) // 푸딩먹기2
        {
            puding[4].SetActive(false); // 윗시럽
            puding[5].SetActive(false); // 앞시럽
            puding[6].SetActive(false); // 푸딩
        }
        else if (Input.GetKey(KeyCode.N)) // 푸딩먹기3
        {
            puding[7].SetActive(false); // 푸딩
        }
        else if (Input.GetKey(KeyCode.M)) // 푸딩먹기4
        {
            puding[8].SetActive(false); // 푸딩
        }
        else if (Input.GetKey(KeyCode.K)) // 푸딩먹기5
        {
            puding[9].SetActive(false); // 푸딩
        }
        else if (Input.GetKey(KeyCode.L)) // 숟가락 내려놓기
        {
            puding[0].SetActive(true);
        }
        
        else if (Input.GetKey(KeyCode.Z)) //밥생성
        {
            dogFood[0].SetActive(true);
            dogFood[1].SetActive(true);
            dogFood[2].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.X)) // 일어나기
        {
            eatDog[0].SetActive(false);
            eatDog[1].SetActive(true);
            eatDog[2].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.C)) // 밥먹고
        {
            dogFood[0].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.V)) // 밥먹고
        {
            dogFood[1].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.B)) // 뒷배경없애기
        {
            homeBack[0].SetActive(false);
            homeBack[1].SetActive(true);
            
        }
        else if (Input.GetKey(KeyCode.N)) // 엎드려자기
        {
            eatDog[0].SetActive(false);
            eatDog[1].SetActive(false);
            eatDog[2].SetActive(true);
        }*/
        /*
        // 꼬리1, 꼬리2, 표정변화1,2, 솜사탕,원상복귀
        else if (Input.GetKey(KeyCode.Z))
        {
            dog[0].SetActive(false);
            dog[1].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.X))
        {
            dog[0].SetActive(true);
            dog[1].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            dog[2].SetActive(false);
            dog[3].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.V))
        {
            dog[2].SetActive(true);
            dog[3].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.B))
        {
            dog[4].SetActive(false);
            dog[5].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            dog[4].SetActive(true);
            dog[5].SetActive(false);
        }*/

        // 현관, 마당만든 후
        /*
        else if (Input.GetKey(KeyCode.Z))
        {
            ch[0].SetActive(false);
            ch[1].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.X))
        {
            ch[1].SetActive(false);
            ch[2].SetActive(true);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            door[0].SetActive(false);
            door[1].SetActive(false);
            door[2].SetActive(false); // 손잡이
            door[3].SetActive(true);
            door[4].SetActive(true); // 손잡이
        }
        else if (Input.GetKey(KeyCode.V))
        {
            dogFood[0].SetActive(true);
        }
        */

        // 짱구 아침밥 먹기
        /*
        // 의자에 앉기
        else if (Input.GetKey(KeyCode.Z))
        {
            ch[0].SetActive(false);
            ch[1].SetActive(true);
        }
        // 밥먹기
        else if (Input.GetKey(KeyCode.X))
        {
            breakfast[0].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            breakfast[1].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.V))
        {
            breakfast[2].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.B))
        {
            breakfast[3].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            breakfast[4].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            breakfast[5].SetActive(false);
        }

        else if (Input.GetKey(KeyCode.F))
        {
            breakfast[6].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            breakfast[7].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.H))
        {
            breakfast[8].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            breakfast[9].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            breakfast[10].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            breakfast[11].SetActive(false);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            breakfast[12].SetActive(false);
        }

        // 짱구 초코비 먹기
        */
        // 들고가기
        /*else if (Input.GetKey(KeyCode.X))
        {
            box[0].SetActive(false);
        }
        // 내려놓기
        else if (Input.GetKey(KeyCode.C))
        {
            box[1].SetActive(true);
        }
        
        // 박스뚜껑열기
        else if (Input.GetKey(KeyCode.V))
        {
            choco[0].SetActive(false);
        }
        // 먹기1
        else if (Input.GetKey(KeyCode.B))
        {
            choco[1].SetActive(false);
        }
        // 먹기2
        else if (Input.GetKey(KeyCode.N))
        {
            choco[2].SetActive(false);
        }
        // 먹기3
        else if (Input.GetKey(KeyCode.M))
        {
            choco[3].SetActive(false);
        }
        */

    }
}
