<h1 align="center">Strong Password Checker II</h1>
<br>

A password is said to be strong if it satisfies all the following criteria:

It has at least 8 characters.<br>
It contains at least one lowercase letter.<br>
It contains at least one uppercase letter.<br>
It contains at least one digit.<br>
It contains at least one special character. <br>
*The special characters are the characters in the following string: "!@#$%^&*()-+".*<br>

It does not contain 2 of the same character in adjacent positions (i.e., "aab" violates this condition, but "aba" does not).<br>
Given a string `password`, return `true` if it is a strong password. Otherwise, return `false`.



*Example 1:*

`Input: password = "IloveLe3tcode!"`<br>
`Output: true`<br>

Explanation: The password meets all the requirements. Therefore, we return true. <br>

*Example 2:*

`Input: password = "Me+You--IsMyDream"`<br>
`Output: false`<br>

Explanation: The password does not contain a digit and also contains 2 of the same character in adjacent positions. Therefore, we return false.