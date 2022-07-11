using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class PriorityQueue<T> where T : IComparable<T> // 조건 : 대소 비교를 할 수 있는 제너릭 타입 (인터페이스)
    {
        List<T> _heap = new List<T>(); //[binaryheap]

        public void Push(T data)
        {
            // 힙의 맨 끝에 새로운 데이터를 삽입한다.
            _heap.Add(data);

            int now = _heap.Count - 1; // 시작 위치
            // 도장 깨기
            while (now > 0) // now 가 0 이 된다 root 가 된다. 그러면 멈춘다.
            {
                // 도장깨기를 시도
                int next = (now - 1) / 2; // 부모의 인덱스
                if (_heap[now].CompareTo(_heap[next]) < 0) // 부모보다 작으면 break
                    break; // 실패

                // 위 if 문 조건에 안걸리면, 바로 위 부모보다 크다는 거니까 
                // 두 값을 교체한다. 교체코드는 대각선 주의
                T temp = _heap[now];
                _heap[now] = _heap[next]; 
                _heap[next] = temp;

                // 검사 위치를 부모의 위치였던 곳으로 이동한다.
                now = next;

            }
        }
        public T Pop() // 우선순위 큐 : 최댓값 먼저 튀어나감 
        {
            // 반환할 데이터를 따로 저장
            T ret = _heap[0];

            // 맨 마지막 데이터를 루트로 이동한다.
            int lastindex = _heap.Count - 1;
            _heap[0] = _heap[lastindex]; // 루트 자리에 마지막 인덱스 값을 넣어준다.
            _heap.RemoveAt(lastindex); // 마지막 인덱스 값을 지워버림
            lastindex--; // 전체 인덱스 하나 줄이기 주의

            // 역 도장깨기
            int now = 0; // 양쪽 모두 클 경우 둘 중 더 큰 숫자쪽으로 내려간다.
            while (true)
            {
                int left = 2 * now + 1;
                int rignt = 2 * now + 2; // 범위 나가는거 주의

                int next = now;
                // 왼쪽 값이 현재 값보다 크면, 왼쪽으로 이동.(아직 교체한 것은 아님. 값만 비교해보고 어디로 내려갈 지 정하는 로직)
                if (left <= lastindex && _heap[next].CompareTo(_heap[left]) < 0) // left <= lastindex : 범위가 마지막 인덱스 벗어나는지 확인
                    next = left;
                // 오른값이 현재 값보다 크면, 오른쪽으로 이동.
                if (rignt <= lastindex && _heap[next].CompareTo(_heap[rignt]) < 0) // else 문을 안썼음. 26 이랑 15 비교해서 더 큰 26 으로 내려가려고 ㅇㅇ else 를 쓰면 이 if 문에 걸리지 않음.
                    next = rignt;

                // 왼쪽 오른쪽 모두 현재값보닥 작으면 종료
                if (next == now)
                    break;

                // 두 값을 교체한다.
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                // 검사 위치를 이동한다.
                now = next;
                 
            }

            return ret;
        }
        public int Count()
        {
            return _heap.Count;
        }
    }
    class Knight : IComparable<Knight>
    {
        public int Id { get; set; }

        public int CompareTo(Knight other) // 우선순위 부여 비교해서 ㅇㅇ
        {
            if (Id == other.Id)
                return 0;
            return Id > other.Id ? -1 : 1; // 1 과 -1 바꾸면 순서 반대가 됨.
        }
    }
    class Program_PriorityQueue
    {
        
        static void Main(string[] args)
        {
            PriorityQueue<Knight> q = new PriorityQueue<Knight>(); // 우선순위가 높은 [가장 높은 값 추출]사람이 먼저 빠져나감.
            q.Push(new Knight() { Id = 20});
            q.Push(new Knight() { Id = 10});
            q.Push(new Knight() { Id = 30});
            q.Push(new Knight() { Id = 50});
            q.Push(new Knight() { Id = 60});
            q.Push(new Knight() { Id = 40});

            // 최단거리 알고리즘 작은 숫자 순서대로 뽑아오고 싶음. : push 할 때 음수로 만들어서 넣어준다. pop 할 때 - 다시 곱해서 양수로 만든다.


            // 제일 큰 수 순서대로 값들이 빠져나옴.
            // 아무리 값이 많더라도, 특정 값 특정 솔루션을 뽑아올 때 우선순위 큐를 사용하면 좋다.
            // push랑 pop 이 매우 빠름.

            // 시간복잡도 빅 오 표기법으로 얼마나 빠른 지 계산해본다.

            while (q.Count() > 0)
            {
                Console.WriteLine(q.Pop().Id);
            }

        }


        
    }
}
