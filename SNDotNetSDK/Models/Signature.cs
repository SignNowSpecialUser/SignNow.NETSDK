﻿
namespace SNDotNetSDK.Models
{
    /**
     * Created by Deepak on 5/14/2015
     * 
     * This model class built to place the signature on the document.
     */
    public class Signature : Fields
    {
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int page_number { get; set; }
        public string data { get; set; }
    }
}