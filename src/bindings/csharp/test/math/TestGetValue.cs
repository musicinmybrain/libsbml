///  @file    TestGetValue.cs
///  @brief   Test the getValue function
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Sarah Keating 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestGetValue.cpp
///  using the conversion program dev/utilities/translateTests/translateTests.pl.
///  Any changes made here will be lost the next time the file is regenerated.
/// 
///  -----------------------------------------------------------------------------
///  This file is part of libSBML.  Please visit http://sbml.org for more
///  information about SBML, and the latest version of libSBML.
/// 
///  Copyright 2005-2010 California Institute of Technology.
///  Copyright 2002-2005 California Institute of Technology and
///                      Japan Science and Technology Corporation.
///  
///  This library is free software; you can redistribute it and/or modify it
///  under the terms of the GNU Lesser General Public License as published by
///  the Free Software Foundation.  A copy of the license agreement is provided
///  in the file named "LICENSE.txt" included with this software distribution
///  and also available online as http://sbml.org/software/libsbml/license.html
///  -----------------------------------------------------------------------------


namespace LibSBMLCSTest.math {

  using libsbmlcs;

  using System;

  using System.IO;

  public class TestGetValue {
    public class AssertionError : System.Exception 
    {
      public AssertionError() : base()
      {
        
      }
    }


    static void assertTrue(bool condition)
    {
      if (condition == true)
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        return;
      }
      else if ( (a == null) || (b == null) )
      {
        throw new AssertionError();
      }
      else if (a.Equals(b))
      {
        return;
      }
  
      throw new AssertionError();
    }

    static void assertNotEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        throw new AssertionError();
      }
      else if ( (a == null) || (b == null) )
      {
        return;
      }
      else if (a.Equals(b))
      {
        throw new AssertionError();
      }
    }

    static void assertEquals(bool a, bool b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(bool a, bool b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(int a, int b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(int a, int b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }


    public void test_getValue_constant_e()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <exponentiale/>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_CONSTANT_E);
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_constant_false()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <false/>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_CONSTANT_FALSE);
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_constant_pi()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <pi/>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_CONSTANT_PI);
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_constant_true()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <true/>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_CONSTANT_TRUE);
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_exponential()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <cn type=\"e-notation\"> 6.3 <sep/> 2 </cn>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_REAL_E);
      n.setValue(4.12,(long)(2));
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_function()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <apply>" + 
    "    <leq/>" + 
    "    <cn> 2 </cn>" + 
    "    <cn> 5 </cn>" + 
    "  </apply>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isNaN );
      n = null;
      n = new ASTNode(libsbml.AST_FUNCTION_POWER);
      ASTNode n1 = new ASTNode(libsbml.AST_INTEGER);
      n1.setValue(2);
      ASTNode n2 = new ASTNode(libsbml.AST_INTEGER);
      n2.setValue(3);
      n.addChild(n1);
      n.addChild(n2);
      assertEquals( true, util_isNaN );
      n = null;
    }

    public void test_getValue_integer()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <cn type=\"integer\"> 6 </cn>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_INTEGER);
      n.setValue((int)(7));
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_name()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <ci> x </ci>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isNaN );
      n = null;
      n = new ASTNode(libsbml.AST_NAME);
      n.setName("w");
      assertEquals( true, util_isNaN );
      n = null;
    }

    public void test_getValue_name_avogadro()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <csymbol encoding=\"text\" definitionURL=\"http://www.sbml.org/sbml/symbols/avogadro\"> x </csymbol>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_NAME_AVOGADRO);
      n.setName("w");
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_name_time()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <csymbol encoding=\"text\" definitionURL=\"http://www.sbml.org/sbml/symbols/time\"> x </csymbol>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isNaN );
      n = null;
      n = new ASTNode(libsbml.AST_NAME_TIME);
      n.setName("w");
      assertEquals( true, util_isNaN );
      n = null;
    }

    public void test_getValue_operator()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <apply>" + 
    "    <plus/>" + 
    "    <cn> 2 </cn>" + 
    "    <cn> 5 </cn>" + 
    "  </apply>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isNaN );
      n = null;
      n = new ASTNode(libsbml.AST_MINUS);
      ASTNode n1 = new ASTNode(libsbml.AST_INTEGER);
      n1.setValue(2);
      ASTNode n2 = new ASTNode(libsbml.AST_INTEGER);
      n2.setValue(3);
      n.addChild(n1);
      n.addChild(n2);
      assertEquals( true, util_isNaN );
      n = null;
    }

    public void test_getValue_rational()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <cn type=\"rational\"> 6 <sep/> 4 </cn>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_RATIONAL);
      n.setValue((long)(3),(long)(2));
      assertEquals( true, util_isEqual );
      n = null;
    }

    public void test_getValue_real()
    {
      ASTNode n = libsbml.readMathMLFromString("<math xmlns='http://www.w3.org/1998/Math/MathML'>" + 
    "  <cn> 0.6 </cn>" + 
    "</math>");
      assertTrue( n != null );
      assertEquals( true, util_isEqual );
      n = null;
      n = new ASTNode(libsbml.AST_REAL);
      n.setValue(0.75);
      assertEquals( true, util_isEqual );
      n = null;
    }

  }
}
