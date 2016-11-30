﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnventEconnomics.Model
{
    public class CurrencyExchangeVo
    {
        public string nome;
        public Result Dia1;
        public Result Dia2;
        public Result Dia3;
        public Result Dia4;
        public Result Dia5;
        public Result Dia6;
        public Result Dia7;

    }

    public partial class Result
    {
        public bool success;
        public string terms;
        public string privacy;
        public bool historical;
        public DateTime date;
        public string timestamp;
        public string source;
        public Quotes quotes;
    }

    public partial class Quotes
    {
        public float usdeur;
        public float usdbrl;
        public float usdars;
    }
}