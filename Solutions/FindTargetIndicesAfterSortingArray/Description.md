<h1 align="center">Find Target Indices After Sorting Array</h1>
<br>

You are given a 0-indexed integer array `nums` and a target element `target`.

A `target index` is an index `i` such that `nums[i] == target`.

Return a list of the target indices of `nums` after sorting `nums` in *non-decreasing* order. If there are no target indices, return an empty list. The returned list must be sorted in increasing order.

*Example 1:*

`Input: nums = [1,2,5,2,3], target = 2`<br>
`Output: [1,2]`<br>

Explanation: After sorting, nums is [1,2,2,3,5].
The indices where nums[i] == 2 are 1 and 2. <br>

*Example 2:*

`Input: nums = [1,2,5,2,3], target = 3`<br>
`Output: [3]`<br>

Explanation: After sorting, nums is [1,2,2,3,5].
The index where nums[i] == 3 is 3.