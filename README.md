# Tree
# 힙 트리 특징
<img width="920" alt="힙트리특징" src="https://user-images.githubusercontent.com/80138709/178213780-80669913-c1d2-44e2-a183-0899d17b1894.png">
<img width="926" alt="힙트리2법칙" src="https://user-images.githubusercontent.com/80138709/178213926-8801a52a-d846-4995-9f34-f4e70ee4d8b1.png">

1. [부모노드]가 가진 값은 항상 [자식노드]가 가진 값보다 크다. <br/>
2. 노드 개수를 알면, 트리 구조는 무조건 확정할 수 있다.
# 힙 트리 구조
<img width="913" alt="힙트리구조" src="https://user-images.githubusercontent.com/80138709/178213849-cab1ba6b-8119-4184-879e-d14333beef2f.png">

1) 마지막 레벨을 제외한 모든 레벨에 노드가 꽉 차 있다 <br/>
2) 마지막 레벨에 노드가 있을 때는, 항상 왼쪽부터 순서대로 채워야 한다. <br/>
# 힙 트리 구현
<img width="946" alt="힙트리구현" src="https://user-images.githubusercontent.com/80138709/178213866-8ac47da2-ad9d-4731-9de2-e8df270937be.png">

배열을 이용해서 힙 구조를 바로 표현할 수 있다. <br/>

# 새로운 값 추가 [도장깨기]
<img width="940" alt="새로운값추가" src="https://user-images.githubusercontent.com/80138709/178214429-96b43422-e49c-4df6-afb5-057b1237f4f4.png">

1. 우선 트리 구조부터 맞춘다.<br/>
2. 도장깨기를 시작한다. (부모와 비교)<br/>
3. 힙 트리 법칙과 구조를 지키면서 추가한다.

# 최대값 꺼내기
<img width="892" alt="최대값꺼내기" src="https://user-images.githubusercontent.com/80138709/178215301-f3524cc8-30ea-46bc-acb9-221e94d8fadc.png">
<img width="901" alt="최대값" src="https://user-images.githubusercontent.com/80138709/178215396-ca525143-ac8b-4ba5-8758-0b8cf4bc9b03.png">

힙 트리 특성상 루트 노드에 있는 값이 제일 크다. <br/>
1. 루트값을 먼저 제거한다.<br/>
2. 뒷수습을 한다. <br/>
3. 데이터가 하나 빠짐. 2법칙에서 트리 구조는 무조건 확정할 수 있음<br/>
4. 제일 마지막에 위치한 데이터를 루트로 옮긴다.<br/>
5. 역 도장 깨기를 시작한다. <br/>


# 우선순위 큐
1. 값이 큰 수에 우선순위를 둬서 뽑아오는 큐를 만들었다.<br/>
2. 값이 가장 작은 수 순서대로 뽑아 오는 방법<br/>
 1) push(-를 곱해서 대입)<br/>
 2) -q.pop() q 에 -를 곱해서 뽑아오면 양수로 다시 만들 수 있다. 음수로 만들면 대소관계가 반대가 되므로 최솟값이 우선순위가 된다.<br/>
 
3. 마지막은 제너릭 타입으로 만들었음
4. 대소 비교를 할 수 있는 제너릭 타입만 받을 수 있도록 인터페이스를 사용했음.
5. IComparable<T> 이거랑 CompareTo 사용.










