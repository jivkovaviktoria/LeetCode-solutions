﻿<h1 align="center">DI String Match</h1>

A permutation perm of n + 1 integers of all the integers in the range [0, n] can be represented as a string s of length n where:

 - `s[i] == 'I' if perm[i] < perm[i + 1]`
 - `s[i] == 'D' if perm[i] > perm[i + 1]`
Given a string s, reconstruct the permutation perm and return it. If there are multiple valid permutations perm, return any of them.