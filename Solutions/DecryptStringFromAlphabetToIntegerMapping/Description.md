<h1 align="center">Decrypt String from Alphabet to Integer Mapping</h1>
<br>

You are given a string s formed by digits and `#`. We want to map s to English lowercase characters as follows:

Characters (`a` to `i`) are represented by (`1` to `9`) respectively.
Characters (`j` to `z`) are represented by (`10#` to `26#`) respectively.
Return the string formed after mapping.

The test cases are generated so that a unique mapping will always exist.

*Examples:*

`Input: s = "10#11#12"` <br>
`Output: "jkab"` <br>
`Explanation: "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".` <br>

<br>

`Input: s = "1326#"` <br>
`Output: "acz"`