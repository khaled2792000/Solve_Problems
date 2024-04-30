import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Node {
    public int data;
    public Node next;

    public Node(int nodeData) {
        this.data = nodeData;
        this.next = null;
    }
}

class LinkedList {
    public Node head;
    public Node tail;

    public LinkedList() {
        this.head = null;
        this.tail = null;
    }

    public void insertNode(int nodeData) {
        Node node = new Node(nodeData);

        if (this.head == null) {
            this.head = node;
        } else {
            this.tail.next = node;
        }

        this.tail = node;
    }
}
class PrintHelper {
    public static void printList(Node node, String sep) {
        while (node != null) {
            System.out.print(node.data);

            node = node.next;

            if (node != null) {
                System.out.print(sep);
            }
        }
    }
}

// need to solve again 
class Result {
    public static Node mergeTwo(Node head1, Node head2) {
        Node result = head1;
       while(head1.next != null) {
            head1  = head1.next;
       }
       head1.next = head2;
       return result;
    }   

}


public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        int tests = Integer.parseInt(bufferedReader.readLine().trim());

        for (int t = 0; t < tests; t++) {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();

            int llist1Count = Integer.parseInt(bufferedReader.readLine().trim());
            for (int i = 0; i < llist1Count; i++) {
                int data = Integer.parseInt(bufferedReader.readLine().trim());
                llist1.insertNode(data);
            }

            int llist2Count = Integer.parseInt(bufferedReader.readLine().trim());
            for (int i = 0; i < llist2Count; i++) {
                int data = Integer.parseInt(bufferedReader.readLine().trim());
                llist2.insertNode(data);
            }

            Node result = Result.mergeTwo(llist1.head, llist2.head);
            PrintHelper.printList(result," ");
        }

        bufferedReader.close();
    }
}
