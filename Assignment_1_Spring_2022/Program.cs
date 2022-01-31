/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                char[] given = new char[10000];
                // giving char limit
                int count = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    //checking if its a vowel
                    if (Convert.ToChar(s[i]) != 'a' && Convert.ToChar(s[i]) != 'e' && Convert.ToChar(s[i]) != 'i' && Convert.ToChar(s[i]) != 'o' && Convert.ToChar(s[i]) != 'u' && Convert.ToChar(s[i]) != 'A' && Convert.ToChar(s[i]) != 'E' && Convert.ToChar(s[i]) != 'I' && Convert.ToChar(s[i]) != 'O' && Convert.ToChar(s[i]) != 'U')
                    {
                        given[count] = s[i];
                        count++;
                        //letters that are not vowels are added
                    }
                    else
                    {
                        continue;
                    }
                }

                string tem = new string(given);
                String final_string = "";
                final_string = tem;
                return final_string;
                //edge case - even empty or null is given same will be returned
                //concept learned - adding new char to existing one and converting string to char
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            string bs1 = "";
            string bs2 = "";
            try
            {
                // write your code here.


                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    bs1 += bulls_string1[i];
                    //adding all words to one string bs1

                }

                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    bs2 += bulls_string2[i];
                    //adding all second array words to bs2
                }
                //checking if both compiled strings are same
                if (bs1 == bs2)
                  
                {
                    return true;
                }

                else
                {
                    return false;
                }
                

            }
            catch (Exception)
            {

                throw;
            }
            //edge cases- nulls, empty are taken care 
            //learned concatination and also string comparision - when small and caps are checked its not same
        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            int count = 0;
            int sum = 0;

            try
            {
                // write your code here
                //checking how many times the element is
                //if the element is different count increases
                //when count is equal to total no of elements - 1 -> because element is equal to itself 
                //based on count we can say if element is unique
                // if unique adds to sum
                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    count = 0;
                    //when ever i changes count refreshes to 0
                    
                    for (int j = 0; j < bull_bucks.Length; j++)
                    {
                        if (bull_bucks[i] != bull_bucks[j])
                        {
                            count++;
                            if (count == bull_bucks.Length - 1)
                            {
                                sum += bull_bucks[i];
                                count = 0;
                            }
                        }
                    }
                }
                return sum;
            }
            catch (Exception)
            {
                throw;
            }
            //learned counter concept to check unique
            //only when all elements are checked sum is added
            //edge cases like when all same elements,none, are checked



        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.

                int size = bulls_grid.GetLength(0);
                int add = 0, mid;

                //in primary diagonal i and j will be same
                for (int i = 0; i < size; i++)
                {
                    add += bulls_grid[i, i];

                }
                //in secondary diagonal i keeps increasing by one from starting and j decreases by one from end
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        add += bulls_grid[i, j];
                        i++;
                    }
                }
                //if its a odd number square matrix middle element is added twice above so we remove one time
                if (size % 2 != 0 && size > 1)
                {
                    mid = (size - 1) / 2;
                    add = add - bulls_grid[mid, mid];
                }
                //edge case when only 1 element is there
                // learned square matrx 2d array iteration i,j and adding and subtraction of req elements

                return add;



            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.

                char[] res = new char[100];
                // simply assigning the respective element to new string and then final res converted and returned
                for (int i = 0; i < bulls_string.Length; i++)
                    
                {
                    res[indices[i]] = bulls_string[i];
                }
                string final = new string(res);

                return final;
                //learned indexing and assigning elements in array
                //edge cases when nulls are present

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //identifying the index of the ch element
                int ind = bulls_string6.IndexOf(ch);
                string outres = "";
                //based on position of ch outres is appended from reverse
                for (int i = ind; i >= 0; i--)
                {
                    outres += bulls_string6[i];
                }
                //now after ch index outres is normally appended
                for (int i = ind + 1; i < bulls_string6.Length; i++)
                {
                    outres += bulls_string6[i];
                }
                //final outres is retured in string
                String prefix_string = outres;
                return prefix_string;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
