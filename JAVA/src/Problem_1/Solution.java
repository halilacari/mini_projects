package Problem_1;

import java.util.ArrayList;

public class Solution {

    public static int[] sortByBits(int[] arr) {
        int[] one_number = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            one_number[i] = convertToBinary(arr[i]);

        }

        for (int i = 0; i < arr.length - 1; i++) {         //Sorting
            for (int j = i + 1; j < arr.length; j++) {
                if (one_number[i] > one_number[j]) {
                    int temp = arr[i];
                    int temp2 = one_number[i];

                    arr[i] = arr[j];
                    one_number[i] = one_number[j];

                    arr[j] = temp;
                    one_number[j] = temp2;
                }
                else if (one_number[i]==one_number[j]){     // if they have same 1 number in binary code. Sort them
                    if (arr[i]>arr[j]){
                        int temp = arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
        }
        return arr;
    }


    public static int counter(ArrayList x) {        //this method calculate one number in binary code
        int count = 0;
        for (int i = 0; i < x.size(); i++) {
            int number = (int) x.get(i);
            if (number == 1) {
                count++;
            }
        }
        return count;
    }

    public static int convertToBinary(int x) {    // this method convert to Binary and send to counter

        ArrayList converToBinary = new ArrayList();
        int one_bite_number = 0;

        if (x == 0) {
            converToBinary.add(0);
            return one_bite_number;
        } else {
            while (x != 1) {
                converToBinary.add(x % 2);
                x = x / 2;
            }
            if (x == 1) {
                converToBinary.add(1);
            }

            one_bite_number = counter(converToBinary);

            return one_bite_number;
        }
    }

    public static void main(String[] args) {

        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8};
        int[] last_Array = sortByBits(array);
        for (int i = 0; i < last_Array.length; i++) {
            System.out.print(last_Array[i] + "\t");
        }
    }
}
