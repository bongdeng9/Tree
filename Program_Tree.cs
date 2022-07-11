using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        class TreeNode<T> // 노드가 있음.
        {
            public T Data { get; set; } // 이 안에 데이터를 물고 있고
            public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>(); // 자식들 정보도 물고 있음 부모가 누구인지는 모름 단방향이므로


        }
        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "R1 개발실" };
            {
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "디자인팀" };
                    //node.Children.Add(new TreeNode<string>() { Data = "전투" });
                    //node.Children.Add(new TreeNode<string>() { Data = "경제" });
                    //node.Children.Add(new TreeNode<string>() { Data = "스토리" });
                    root.Children.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "프로그래밍팀" };
                    node.Children.Add(new TreeNode<string>() { Data = "서버" });
                    node.Children.Add(new TreeNode<string>() { Data = "클라" });
                    node.Children.Add(new TreeNode<string>() { Data = "엔진" });
                    root.Children.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "아트팀" };
                    //node.Children.Add(new TreeNode<string>() { Data = "배경" });
                    //node.Children.Add(new TreeNode<string>() { Data = "캐릭터" });
                    root.Children.Add(node);
                }
            }
            return root;
        }

        static void PrintTree(TreeNode<string> root)
        {
            // 서브트리의 개념을 사용해서 재귀함수를 이용한다.
            Console.WriteLine(root.Data);
            
            foreach (TreeNode<string> child in root.Children)
                PrintTree(child);
            
        }

        static int GetHeight(TreeNode<string> root)
        {
            int height = 0;

            // 자식이 반환한 것 중에서 가장 큰 값을 높이로 정하면 됨.
            foreach (TreeNode<string> child in root.Children)
            {
                int newHeight = GetHeight(child) + 1;

                if (height <= newHeight) // 덮어씌우기 최대값 찾기
                    height = newHeight; // 새로운 최대값으로 값을 덮어쓴다.

                height = Math.Max(height, newHeight); // Math 의 내장함수 사용. 큰 값을 반환
            }

            return height;
        }

        static void Main(string[] args)
        {
            // 그래프 경우 관계도를 표현할 대, 정점을 행렬이나 리스트로 표현.
            // 이유 : 데이터가 잘 바뀌지 않는 환경에서 사용 : 정적이다

            // 트리는 데이터들의 삽입 삭제 및 변형이 매우 많음.
            // 그래서 실제 노드를 만들어서 연결을 해줘야 됨.
            TreeNode<string> root = MakeTree();

            PrintTree(root);

            Console.WriteLine(GetHeight(root));
        }


        
    }
}
