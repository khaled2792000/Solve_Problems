/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function (nums1, m, nums2, n) {
    for (num1_index = 0, num2_index = 0; num1_index < m && num2_index < n;) {
        if (nums1[num1_index] > nums2[num2_index]) {
            nums1.splice(num1_index, 0, nums2[num2_index]);
            num1_index++;
            num2_index++;
        } else {
            nums1.splice(num1_index, 0, nums2[num2_index]);
            num2_index++;
        }
    }
};
