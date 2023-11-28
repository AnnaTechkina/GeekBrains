package JAVA.Lesson4;

import java.util.LinkedList;
import java.util.Collections;


public class task1 {
    public static void main(String[] args) {
        LinkedList<String> list = new LinkedList<String>();
        list.add("anna");
        list.add("bob");
        list.add("clean");
        LinkedList<String> reversedList = reverseLinkedList(list);
        System.out.println(reversedList); 
    }
    public static LinkedList reverseLinkedList(LinkedList list) {
            Collections.reverse(list);
            return list;
    }
}
