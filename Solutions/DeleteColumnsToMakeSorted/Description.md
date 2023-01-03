<h1 align="center">Delete Columns to Make Sorted</h1>
<br>

You are given an array of `n` strings `strs`, all of the same length.

The strings can be arranged such that there is one on each line, making a grid. For example, `strs = ["abc", "bce", "cae"]` can be arranged as:

`abc`<br>
`bce`<br>
`cae`<br>

You want to delete the columns that are not sorted lexicographically. In the above example (0-indexed), columns 0 ('a', 'b', 'c') and 2 ('c', 'e', 'e') are sorted while column 1 ('b', 'c', 'a') is not, so you would delete column 1.

Return the number of columns that you will delete.



*Example 1:*

`Input: strs = ["cba","daf","ghi"]`<br>
`Output: 1`<br>

Explanation: The grid looks as follows:
cba
daf
ghi
Columns 0 and 2 are sorted, but column 1 is not, so you only need to delete 1 column.

*Example 2:*

`Input: strs = ["a","b"]`<br>
`Output: 0`

Explanation: The grid looks as follows:
a
b
Column 0 is the only column and is sorted, so you will not delete any columns.