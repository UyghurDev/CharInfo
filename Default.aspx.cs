using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CharInfo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Convert_Click(object sender, EventArgs e)
    {
        getInfo();
    }

    private void getInfo()
    {
        DataTable dtChars = MakeNamesTable();
        int nID = 1;
        foreach (char chr in txtSource.Text)
        {
            DataRow dr = dtChars.NewRow();
            //dr["ID"] = nID;
            dr["Index"] = nID - 1;
            dr["Char"] = chr;
            dr["Code"] = ((Int32)chr).ToString();
            dr["HexCode"] = ((Int32)chr).ToString("x");
            dr["NumericValue"] = Char.GetNumericValue(chr);
            dr["UnicodeCategory"] = Char.GetUnicodeCategory(chr).ToString();
            dr["IsControl"] = Char.IsControl(chr);
            dr["IsDigit"] = Char.IsDigit(chr);
            dr["IsHighSurrogate"] = Char.IsHighSurrogate(chr);
            dr["IsLetter"] = Char.IsLetter(chr);
            dr["IsLetterOrDigit"] = Char.IsLetterOrDigit(chr);
            dr["IsLower"] = Char.IsLower(chr);
            dr["IsLowSurrogate"] = Char.IsLowSurrogate(chr);
            dr["IsNumber"] = Char.IsNumber(chr);
            dr["IsPunctuation"] = Char.IsPunctuation(chr);
            dr["IsSeparator"] = Char.IsSeparator(chr);
            dr["IsSurrogate"] = Char.IsSurrogate(chr);
            dr["IsSymbol"] = Char.IsSymbol(chr);
            dr["IsUpper"] = Char.IsUpper(chr);
            dr["IsWhiteSpace"] = Char.IsWhiteSpace(chr);
            dr["HashCode"] = chr.GetHashCode().ToString();
            dr["Type"] = chr.GetType().ToString();
            dr["TypeCode"] = chr.GetTypeCode().ToString();
            dtChars.Rows.Add(dr);

            nID++;
        }
        dgvResult.DataSource = dtChars;
        dgvResult.DataMember = "CharInfo";
        dgvResult.DataBind();
        
    }

    private DataTable MakeNamesTable()
    {
        // Create a new DataTable titled 'Names.'
        DataTable namesTable = new DataTable("CharInfo");

        //// Add three column objects to the table.
        //DataColumn idColumn = new DataColumn();
        //idColumn.DataType = System.Type.GetType("System.Int32");
        //idColumn.ColumnName = "id";
        //idColumn.AutoIncrement = true;
        //namesTable.Columns.Add(idColumn);

        DataColumn indexColumn = new DataColumn();
        indexColumn.DataType = System.Type.GetType("System.Int32");
        indexColumn.ColumnName = "Index";
        indexColumn.AutoIncrement = false;
        namesTable.Columns.Add(indexColumn);

        DataColumn CharColumn = new DataColumn();
        CharColumn.DataType = System.Type.GetType("System.String");
        CharColumn.ColumnName = "Char";
        //fNameColumn.DefaultValue = "Fname";
        namesTable.Columns.Add(CharColumn);

        DataColumn CodeColumn = new DataColumn();
        CodeColumn.DataType = System.Type.GetType("System.String");
        CodeColumn.ColumnName = "Code";
        //CodeColumn.AutoIncrement = false;
        namesTable.Columns.Add(CodeColumn);

        DataColumn HexCodeColumn = new DataColumn();
        HexCodeColumn.DataType = System.Type.GetType("System.String");
        HexCodeColumn.ColumnName = "HexCode";
        //HexCodeColumn.AutoIncrement = false;
        namesTable.Columns.Add(HexCodeColumn);

        //NumericValue
        DataColumn NumericValueColumn = new DataColumn();
        NumericValueColumn.DataType = System.Type.GetType("System.Int32");
        NumericValueColumn.ColumnName = "NumericValue";
        NumericValueColumn.AutoIncrement = false;
        namesTable.Columns.Add(NumericValueColumn);

        //UnicodeCategory
        DataColumn UnicodeCategoryColumn = new DataColumn();
        UnicodeCategoryColumn.DataType = System.Type.GetType("System.String");
        UnicodeCategoryColumn.ColumnName = "UnicodeCategory";
        namesTable.Columns.Add(UnicodeCategoryColumn);

        //IsControl
        DataColumn IsControlColumn = new DataColumn();
        IsControlColumn.DataType = System.Type.GetType("System.Boolean");
        IsControlColumn.ColumnName = "IsControl";
        namesTable.Columns.Add(IsControlColumn);

        //IsDigit
        DataColumn IsDigitColumn = new DataColumn();
        IsDigitColumn.DataType = System.Type.GetType("System.Boolean");
        IsDigitColumn.ColumnName = "IsDigit";
        namesTable.Columns.Add(IsDigitColumn);
        //IsHighSurrogate
        DataColumn IsHighSurrogateColumn = new DataColumn();
        IsHighSurrogateColumn.DataType = System.Type.GetType("System.Boolean");
        IsHighSurrogateColumn.ColumnName = "IsHighSurrogate";
        namesTable.Columns.Add(IsHighSurrogateColumn);
        //IsLetter
        DataColumn IsLetterColumn = new DataColumn();
        IsLetterColumn.DataType = System.Type.GetType("System.Boolean");
        IsLetterColumn.ColumnName = "IsLetter";
        namesTable.Columns.Add(IsLetterColumn);
        //"IsLetterOrDigit
        DataColumn IsLetterOrDigitColumn = new DataColumn();
        IsLetterOrDigitColumn.DataType = System.Type.GetType("System.Boolean");
        IsLetterOrDigitColumn.ColumnName = "IsLetterOrDigit";
        namesTable.Columns.Add(IsLetterOrDigitColumn);

        //"IsLower
        DataColumn IsLowerColumn = new DataColumn();
        IsLowerColumn.DataType = System.Type.GetType("System.Boolean");
        IsLowerColumn.ColumnName = "IsLower";
        namesTable.Columns.Add(IsLowerColumn);

        //IsLowSurrogate
        DataColumn IsLowSurrogateColumn = new DataColumn();
        IsLowSurrogateColumn.DataType = System.Type.GetType("System.Boolean");
        IsLowSurrogateColumn.ColumnName = "IsLowSurrogate";
        namesTable.Columns.Add(IsLowSurrogateColumn);

        //IsNumber
        DataColumn IsNumberColumn = new DataColumn();
        IsNumberColumn.DataType = System.Type.GetType("System.Boolean");
        IsNumberColumn.ColumnName = "IsNumber";
        namesTable.Columns.Add(IsNumberColumn);

        //IsPunctuation
        DataColumn IsPunctuationColumn = new DataColumn();
        IsPunctuationColumn.DataType = System.Type.GetType("System.Boolean");
        IsPunctuationColumn.ColumnName = "IsPunctuation";
        namesTable.Columns.Add(IsPunctuationColumn);

        //IsSeparator
        DataColumn IsSeparatorColumn = new DataColumn();
        IsSeparatorColumn.DataType = System.Type.GetType("System.Boolean");
        IsSeparatorColumn.ColumnName = "IsSeparator";
        namesTable.Columns.Add(IsSeparatorColumn);

        //IsSurrogate
        DataColumn IsSurrogateColumn = new DataColumn();
        IsSurrogateColumn.DataType = System.Type.GetType("System.Boolean");
        IsSurrogateColumn.ColumnName = "IsSurrogate";
        namesTable.Columns.Add(IsSurrogateColumn);

        //IsSymbol
        DataColumn IsSymbolColumn = new DataColumn();
        IsSymbolColumn.DataType = System.Type.GetType("System.Boolean");
        IsSymbolColumn.ColumnName = "IsSymbol";
        namesTable.Columns.Add(IsSymbolColumn);

        //IsUpper
        DataColumn IsUpperColumn = new DataColumn();
        IsUpperColumn.DataType = System.Type.GetType("System.Boolean");
        IsUpperColumn.ColumnName = "IsUpper";
        namesTable.Columns.Add(IsUpperColumn);

        //IsWhiteSpace
        DataColumn IsWhiteSpaceColumn = new DataColumn();
        IsWhiteSpaceColumn.DataType = System.Type.GetType("System.Boolean");
        IsWhiteSpaceColumn.ColumnName = "IsWhiteSpace";
        namesTable.Columns.Add(IsWhiteSpaceColumn);

        //HashCode
        DataColumn HashCodeColumn = new DataColumn();
        HashCodeColumn.DataType = System.Type.GetType("System.String");
        HashCodeColumn.ColumnName = "HashCode";
        namesTable.Columns.Add(HashCodeColumn);

        //Type
        DataColumn TypeColumn = new DataColumn();
        TypeColumn.DataType = System.Type.GetType("System.String");
        TypeColumn.ColumnName = "Type";
        namesTable.Columns.Add(TypeColumn);

        //TypeCode
        DataColumn TypeCodeColumn = new DataColumn();
        TypeCodeColumn.DataType = System.Type.GetType("System.String");
        TypeCodeColumn.ColumnName = "TypeCode";
        namesTable.Columns.Add(TypeCodeColumn);

        // Create an array for DataColumn objects.
        //DataColumn[] keys = new DataColumn[1];
        //keys[0] = idColumn;
        //namesTable.PrimaryKey = keys;

        // Return the new DataTable.
        return namesTable;
    }
}
