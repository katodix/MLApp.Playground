//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleMulticlassClassification.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("endo"), LoadColumn(0)]
        public float Endo { get; set; }


        [ColumnName("meso"), LoadColumn(1)]
        public float Meso { get; set; }


        [ColumnName("ecto"), LoadColumn(2)]
        public float Ecto { get; set; }


        [ColumnName("type"), LoadColumn(3)]
        public string Type { get; set; }


    }
}
