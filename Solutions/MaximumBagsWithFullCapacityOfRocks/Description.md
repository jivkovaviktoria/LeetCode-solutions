<h1 align="center">Maximum Bags With Full Capacity of Rocks</h1>
<br>


You have `n` bags numbered from `0` to `n - 1`. 
You are given two 0-indexed integer arrays `capacity`
and `rocks`. The `i`*th* bag can hold a maximum of `capacity[i]`
rocks and currently contains `rocks[i]` rocks. You are also
given an integer `additionalRocks`, the number of additional
rocks you can place in any of the bags.


Return the maximum number of bags that could have 
full capacity after placing the additional rocks in
some bags.

<br>

*Examples:* <br>
`Input: capacity = [2,3,4,5], rocks = [1,2,4,4], additionalRocks = 2`<br>
`Output: 3`<br>

*Explanation:<br>*

Place 1 rock in bag 0 and 1 rock in bag 1.
The number of rocks in each bag are now [2,3,4,4].
Bags 0, 1, and 2 have full capacity.
There are 3 bags at full capacity, so we return 3.
It can be shown that it is not possible to have more than 3 bags at full capacity.
Note that there may be other ways of placing the rocks that result in an answer of 3.