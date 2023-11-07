# Codility-Brackets
A string S consisting of N characters is considered to be properly nested</br> 
if any of the following conditions is true:</br>
S is empty;</br>
S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;</br>
S has the form "VW" where V and W are properly nested strings.</br>
For example, the string "{[()()]}" is properly nested but "([)()]" is not.

Write a function:</br>
class Solution { public int solution(String S); }</br>
that, given a string S consisting of N characters,</br>
returns 1 if S is properly nested and 0 otherwise.</br>

For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]",</br> 
the function should return 0, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..200,000];</br>
string S is made only of the following characters: '(', '{', '[', ']', '}' and/or ')'.
