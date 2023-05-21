﻿<h1 align="center">Lexicographically Smallest Palindrome</h1>

You are given a string `s` consisting of lowercase English letters, and you are allowed to perform operations on it. In one operation, you can replace a character in `s` with another lowercase English letter.

Your task is to make `s` a palindrome with the minimum number of operations possible. If there are multiple palindromes that can be made using the minimum number of operations, make the lexicographically smallest one.

A string a is lexicographically smaller than a string `b` (of the same length) if in the first position where `a` and `b` differ, string `a` has a letter that appears earlier in the alphabet than the corresponding letter in `b`.

Return the resulting palindrome string.