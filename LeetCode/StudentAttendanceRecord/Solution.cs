using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StudentAttendanceRecord
{
    //https://leetcode.com/problems/student-attendance-record-i/description/
    public class Solution
    {
        public bool CheckRecord(string s)
        {
            var absenceCount = 0;
            var lateCount = 0;

            for (int i = 0, n = s.Length; i < n; i++)
            {
                if (s[i] == 'A')
                {
                    lateCount = 0;
                    absenceCount++;
                    if (absenceCount > 1)
                    {
                        return false;
                    }
                }
                else if (s[i] == 'L')
                {
                    lateCount++;
                    if (lateCount > 2)
                    {
                        return false;
                    }
                }
                else
                {
                    lateCount = 0;
                }
            }
            return true;
        }
    }
}
