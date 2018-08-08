using System;

public class GakkiClass
{
	public GakkiClass()
	{
        
    }

    //延迟
    public void Delay(int milliSecond)
    {
        int start = Environment.TickCount;
        while (Math.Abs(Environment.TickCount - start) < milliSecond)
        {
            Application.DoEvents(); //在大运算量循环内，加Application.DoEvents可以防止界面停止响应
        }
    }
}
