﻿using Pk3DSRNGTool.RNG;

namespace Pk3DSRNGTool
{
    internal class ModelStatus
    {
        private SFMT sfmt;
        private int cnt;
        private ulong getrand { get { cnt++; return sfmt.Nextulong(); } }

        public byte Modelnumber;
        public int[] remain_frame;
        public bool phase;

        public static bool raining;

        public ModelStatus(byte n, SFMT st)
        {
            sfmt = (SFMT)st.DeepCopy();
            Modelnumber = n;
            remain_frame = new int[n];
        }

        public int NextState()
        {
            cnt = 0;
            for (int i = 0; i < Modelnumber; i++)
            {
                if (remain_frame[i] > 1)                       //Cooldown 2nd part
                {
                    remain_frame[i]--;
                    continue;
                }
                if (remain_frame[i] < 0)                       //Cooldown 1st part
                {
                    if (++remain_frame[i] == 0)                //Blinking
                        remain_frame[i] = (int)(getrand % 3) == 0 ? 36 : 30;
                    continue;
                }
                if ((int)(getrand & 0x7F) == 0)                //Not Blinking
                    remain_frame[i] = -5;
            }
            if (raining && (phase = !phase))
            {
                frameshift(2);
                cnt += 2;
            }
            return cnt;
        }

        public void frameshift(int n)
        {
            for (int i = 0; i < n; i++)
                sfmt.Next();
        }

        public void CopyTo(ModelStatus st)
        {
            st.remain_frame = (int[])remain_frame.Clone();
            st.phase = phase;
        }
    }
}