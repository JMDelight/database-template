//Find and Replace these with your values. You will need to check the rdr datatypes in find and get all.
// ##tablename##
// ClassName
// property1DataType
// property1tablename
// property1
// Property1
// property2DataType
// property2tablename
// property2
// Property2
// property3DataType
// property3tablename
// property3
// Property3
// property4DataType
// property4tablename
// property4
// Property4
// property5DataType
// property5tablename
// property5
// Property5
// property6DataType
// property6tablename
// property6
// Property6
// property7DataType
// property7tablename
// property7
// Property7
// property8DataType
// property8tablename
// property8
// Property8


using System.Collections.Generic;
using System.Data.SqlClient;
using System;


namespace Library
{
  public class ClassName
  {
    private int _id;
    private property1DataType _property1;
    private property2DataType _property2;
    private property3DataType _property3;
    private property4DataType _property4;
    private property5DataType _property5;
    private property6DataType _property6;
    private property7DataType _property7;
    private property8DataType _property8;


    public ClassName(property1DataType property1, string property2, int property3, bool property4, string property5, string property6, int property7, bool property8, int id = 0)
    {
      _property1 = property1;
      _property2 = property2;
      _property3 = property3;
      _property4 = property4;
      _property5 = property5;
      _property6 = property6;
      _property7 = property7;
      _property8 = property8;
      _id = id;
    }
    public override bool Equals(System.Object otherClassName)
    {
      if (!(otherClassName is ClassName))
      {
        return false;
      }
      else
      {
        ClassName newClassName = (ClassName) otherClassName;
        bool idEquality = this.GetId() == newClassName.GetId();
        property1DataType property1Equality = this.GetProperty1() == newClassName.GetProperty1();
        property2DataType property2Equality = this.GetProperty2() == newClassName.GetProperty2();
        property3DataType property3Equality = this.GetProperty3() == newClassName.GetProperty3();
        property4DataType property4Equality = this.GetProperty4() == newClassName.GetProperty4();
        property5DataType property5Equality = this.GetProperty5() == newClassName.GetProperty5();
        property6DataType property6Equality = this.GetProperty6() == newClassName.GetProperty6();
        property7DataType property7Equality = this.GetProperty7() == newClassName.GetProperty7();
        property8DataType property8Equality = this.GetProperty8() == newClassName.GetProperty8();
        return (idEquality && property1Equality && property2Equality && property3Equality && property4Equality && property5Equality && property6Equality && property7Equality && property8Equality);
      }
    }
    public property1DataType GetProperty1()
    {
      return _property1;
    }
    public void SetProperty1(property1DataType newProperty1)
    {
      _property1 = newProperty1;
    }

    public property3DataType GetProperty2()
    {
      return _property2;
    }
    public void SetProperty2(property3DataType newProperty2)
    {
      _property2 = newProperty2;
    }

    public property3DataType GetProperty3()
    {
      return _property3;
    }
    public void SetProperty3(property3DataType newProperty3)
    {
      _property3 = newProperty3;
    }

    public property4DataType GetProperty4()
    {
      return _property4;
    }
    public void SetProperty4(property4DataType newProperty4)
    {
      _property4 = newProperty4;
    }

    public property5DataType GetProperty5()
    {
      return _property5;
    }
    public void SetProperty5(property5DataType newProperty5)
    {
      _property5 = newProperty5;
    }

    public property6DataType GetProperty6()
    {
      return _property6;
    }
    public void SetProperty6(property6DataType newProperty6)
    {
      _property6 = newProperty6;
    }

    public property7DataType GetProperty7()
    {
      return _property7;
    }
    public void SetProperty7(property7DataType newProperty7)
    {
      _property7 = newProperty7;
    }

    public property8DataType GetProperty8()
    {
      return _property8;
    }
    public void SetProperty8(property8DataType newProperty8)
    {
      _property8 = newProperty8;
    }

    public int GetId()
    {
      return _id;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }

    public static List<ClassName> GetAll()
    {
      List<ClassName> allClassNames = new List<ClassName> {};

      SqlConnection conn = DB.Connection();
      SqlDataReader rdr = null;
      conn.Open();

      SqlCommand cmd = new SqlCommand("SELECT * FROM ##tablename##;", conn);
      rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        string id = rdr.GetInt32(0);
        property1DataType property1 = rdr.Getproperty1DataType(1);
        property2DataType property2 = rdr.Getproperty2DataType(2);
        property3DataType property3 = rdr.Getproperty3DataType(3);
        property4DataType property4 = rdr.Getproperty4DataType(4);
        property5DataType property5 = rdr.Getproperty5DataType(5);
        property6DataType property6 = rdr.Getproperty6DataType(6);
        property7DataType property7 = rdr.Getproperty7DataType(7);
        property8DataType property8 = rdr.Getproperty8DataType(8);
        ClassName newClassName = new ClassName(property1, property2, property3, property4, property5, property6, property7, property8, id);
        allClassNames.Add(newClassName);
      }
      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
      return allClassNames;
    }
    public void Save()
    {
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr;
      conn.Open();

      SqlCommand cmd = new SqlCommand("INSERT INTO ##tablename## (property1tablename, property2tablename, property3tablename, property4tablename, property5tablename, property6tablename, property7tablename, property8tablename) OUTPUT INSERTED.id VALUES (@property1, @property2, @property3, @property4, @property5, @property6, @property7, @property8);", conn);

      SqlParameter property1Parameter = new SqlParameter();
      property1Parameter.ParameterName = "@property1";
      property1Parameter.Value = this.GetProperty1();
      cmd.Parameters.Add(property1Parameter);

      SqlParameter property2Parameter = new SqlParameter();
      property2Parameter.ParameterName = "@property2";
      property2Parameter.Value = this.GetProperty2();
      cmd.Parameters.Add(property2Parameter);

      SqlParameter property3Parameter = new SqlParameter();
      property3Parameter.ParameterName = "@property3";
      property3Parameter.Value = this.GetProperty3();
      cmd.Parameters.Add(property3Parameter);

      SqlParameter property4Parameter = new SqlParameter();
      property4Parameter.ParameterName = "@property4";
      property4Parameter.Value = this.GetProperty4();
      cmd.Parameters.Add(property4Parameter);

      SqlParameter property5Parameter = new SqlParameter();
      property5Parameter.ParameterName = "@property5";
      property5Parameter.Value = this.GetProperty5();
      cmd.Parameters.Add(property5Parameter);

      SqlParameter property6Parameter = new SqlParameter();
      property6Parameter.ParameterName = "@property6";
      property6Parameter.Value = this.GetProperty6();
      cmd.Parameters.Add(property6Parameter);

      SqlParameter property7Parameter = new SqlParameter();
      property7Parameter.ParameterName = "@property7";
      property7Parameter.Value = this.GetProperty7();
      cmd.Parameters.Add(property7Parameter);

      SqlParameter property8Parameter = new SqlParameter();
      property8Parameter.ParameterName = "@property8";
      property8Parameter.Value = this.GetProperty8();
      cmd.Parameters.Add(property8Parameter);


      rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        this._id = rdr.GetInt32(0);
      }
      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
    }
    public static ClassName Find(int id)
    {
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr = null;
      conn.Open();

      SqlCommand cmd = new SqlCommand("SELECT * FROM ##tablename## WHERE id = @id;", conn);
      SqlParameter idParameter = new SqlParameter();
      idParameter.ParameterName = "@id";
      idParameter.Value = id.ToString();
      cmd.Parameters.Add(idParameter);
      rdr = cmd.ExecuteReader();

      int id = 0;
      property1DataType property1 = null;
      property2DataType property2 = null;
      property3DataType property3 = null;
      property4DataType property4 = null;
      property5DataType property5 = null;
      property6DataType property6 = null;
      property7DataType property7 = null;
      property8DataType property8 = null;


      while(rdr.Read())
      {
        foundid = rdr.GetInt32(0);
        foundproperty1 = rdr.Getproperty1DataType(1);
        foundproperty2 = rdr.Getproperty2DataType(2);
        foundproperty3 = rdr.Getproperty3DataType(3);
        foundproperty4 = rdr.Getproperty4DataType(4);
        foundproperty5 = rdr.Getproperty5DataType(5);
        foundproperty6 = rdr.Getproperty6DataType(6);
        foundproperty7 = rdr.Getproperty7DataType(7);
        foundproperty8 = rdr.Getproperty8DataType(8);
      }
      ClassName foundClassName = new ClassName(foundProperty1, foundProperty2, foundProperty3, foundProperty4, foundProperty1, foundProperty2, foundProperty3, foundProperty4, foundClassNameId);

      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
      return foundClassName;
    }

    public static void Update(int queryId, ClassName updateClassName)
    {
      SqlConnection conn = DB.Connection();
      conn.Open();

      SqlCommand cmd = new SqlCommand("UPDATE ##tablename## SET property1tablename = @property1, property2tablename = @property2, property3tablename = @property3, property4tablename = @property4, property5tablename = @property5, property6tablename = @property6, property7tablename = @property7, property8tablename = @property8  WHERE id = @queryId;", conn);

      SqlParameter property1Parameter = new SqlParameter();
      property1Parameter.ParameterName = "@property1";
      property1Parameter.Value = this.GetProperty1();
      cmd.Parameters.Add(property1Parameter);

      SqlParameter property2Parameter = new SqlParameter();
      property2Parameter.ParameterName = "@property2";
      property2Parameter.Value = this.GetProperty2();
      cmd.Parameters.Add(property2Parameter);

      SqlParameter property3Parameter = new SqlParameter();
      property3Parameter.ParameterName = "@property3";
      property3Parameter.Value = this.GetProperty3();
      cmd.Parameters.Add(property3Parameter);

      SqlParameter property4Parameter = new SqlParameter();
      property4Parameter.ParameterName = "@property4";
      property4Parameter.Value = this.GetProperty4();
      cmd.Parameters.Add(property4Parameter);

      SqlParameter property5Parameter = new SqlParameter();
      property5Parameter.ParameterName = "@property5";
      property5Parameter.Value = this.GetProperty5();
      cmd.Parameters.Add(property5Parameter);

      SqlParameter property6Parameter = new SqlParameter();
      property6Parameter.ParameterName = "@property6";
      property6Parameter.Value = this.GetProperty6();
      cmd.Parameters.Add(property6Parameter);

      SqlParameter property7Parameter = new SqlParameter();
      property7Parameter.ParameterName = "@property7";
      property7Parameter.Value = this.GetProperty7();
      cmd.Parameters.Add(property7Parameter);

      SqlParameter property8Parameter = new SqlParameter();
      property8Parameter.ParameterName = "@property8";
      property8Parameter.Value = this.GetProperty8();
      cmd.Parameters.Add(property8Parameter);

      cmd.ExecuteNonQuery();

      if (conn != null)
      {
        conn.Close();
      }
    }

    public static void Delete(int QueryId)
    {
      SqlConnection conn = DB.Connection();
      conn.Open();
      SqlCommand cmd = new SqlCommand("DELETE FROM ##tablename## WHERE id = @ClassNameId;", conn);
      SqlParameter patronIdParameter = new SqlParameter();
      patronIdParameter.ParameterName = "@ClassNameId";
      patronIdParameter.Value = QueryId.ToString();
      cmd.Parameters.Add(patronIdParameter);

      cmd.ExecuteNonQuery();

      if (conn != null)
      {
        conn.Close();
      }
    }
    public static void DeleteAll()
    {
      SqlConnection conn = DB.Connection();
      conn.Open();
      SqlCommand cmd = new SqlCommand("DELETE FROM ##tablename##;", conn);
      cmd.ExecuteNonQuery();
    }
  }
}
