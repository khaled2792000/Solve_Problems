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


class Result {


public static int itIsTheSame(Node head1, Node head2) {
    while (head1 != null && head2 != null) {
        if (head1.data != head2.data) {
            return 0; // Data doesn't match, lists are different
        }
        head1 = head1.next;
        head2 = head2.next;
    }
    // If both lists end simultaneously, they are the same
    return head1 == null && head2 == null ? 1 : 0;
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

            int result = Result.itIsTheSame(llist1.head, llist2.head);
            System.out.println(result);
        }

        bufferedReader.close();
    }
}
