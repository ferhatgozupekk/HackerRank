public static long aVeryBigSum(List<long> ar)
    {
        long sonuc = 0;
        foreach(long item in ar){
            sonuc += item;
        }
        return sonuc;
    }