An array is monotonic if it is either monotone increasing or monotone decreasing.

An array nums is monotone increasing if for all `i <= j`, `nums[i] <= nums[j]`. An array nums is monotone decreasing if for all `i <= j`, `nums[i] >= nums[j]`.

Given an integer array `nums`, return `true` if the given array is monotonic, or `false` otherwise.
<br>

*Examples:*

`Input: nums = [1,2,2,3]`<br>
`Output: true`

<br>

`Input: nums = [1,3,2]`<br>
`Output: false`