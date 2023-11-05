package Problem_3;


import java.util.Arrays;
import java.util.List;
public class Solution {

    public static char nextGreatestLetter(char[] letters, char target) {
        char temp = 0;
        boolean found = false;
        Arrays.sort(letters);
        for(int i=0; i<letters.length;i++){
            if(letters[i]>target){
                temp=letters[i];
                found=true;
                break;
            }
        }
        if(found){
            return temp;
        }else{
            return letters[0];
        }
    }
}

/*Intuition - #Approach
I thought it was pretty simple. I sorted the series from smallest to largest.
While browsing through the array with for, if it finds a letter larger than the target, it will assign it to a variable.
And the bool value indicating that it is found will be true.
If this does not happen: the string will not contain a letter larger than the target.
Therefore, it will assign the initial value to the variable and return the value.

Complexity
Time complexity:
O(n)*/