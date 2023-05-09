﻿namespace SinglyLinkedList;

public class SinglyLinkedList<T>
{
    private Node<T>? _head;
    public int Count;

    public SinglyLinkedList()
    {
        _head = null;
        Count = 0;
    }
    
    /// <summary>
    /// 리스트의 마지막에 데이터 노드를 추가 합니다
    /// </summary>
    /// <param name="data">추가할 데이터</param>
    public void AddLast(T data)
    {
        // 데이터를 추가 하기 위한 노드 생성
        Node<T> newNode = new Node<T>(data);
        
        // 리스트에 추가된 데이터가 없을 경우
        if (Count == 0)
        {
            // 현재 헤드에 newNode를 대입
            _head = newNode;
        }
        else
        {
            // currentNode는 헤드 노드로 설정
            Node<T>? currentNode = _head;
            
            // currentNode의 다음 노드가 null이 아닐 경우 반복
            while (currentNode.Next != null)
            {
                // currentNode에 다음 노드를 설정
                currentNode = currentNode.Next;
            }
            
            // 리스트의 마지막 노드가 됨
            // 마지막 노드의 다음 노드로 newNode를 추가
            currentNode.Next = newNode;
        }
        
        // 리스트의 카운트를 증가
        Count++;
    }
}