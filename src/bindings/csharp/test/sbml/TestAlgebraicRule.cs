///  @file    TestAlgebraicRule.cs
///  @brief   AlgebraicRule unit tests
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Ben Bornstein 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestAlgebraicRule.c
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


namespace LibSBMLCSTest.sbml {

  using libsbmlcs;

  using System;

  using System.IO;

  public class TestAlgebraicRule {
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

    private AlgebraicRule AR;

    public void setUp()
    {
      AR = new  AlgebraicRule(2,4);
      if (AR == null);
      {
      }
    }

    public void tearDown()
    {
      (AR) = null;
    }

    public void test_AlgebraicRule_create()
    {
      assertTrue( AR.getTypeCode() == libsbml.SBML_ALGEBRAIC_RULE );
      assertTrue( AR.getMetaId() == "" );
      assertTrue( AR.getNotes() == null );
      assertTrue( AR.getAnnotation() == null );
      assertTrue( AR.getFormula() == "" );
      assertTrue( AR.getMath() == null );
    }

    public void test_AlgebraicRule_createWithFormula()
    {
      ASTNode math;
      string formula;
      AlgebraicRule ar = new  AlgebraicRule(2,4);
      ar.setFormula( "1 + 1");
      assertTrue( ar.getTypeCode() == libsbml.SBML_ALGEBRAIC_RULE );
      assertTrue( ar.getMetaId() == "" );
      math = ar.getMath();
      assertTrue( math != null );
      formula = libsbml.formulaToString(math);
      assertTrue( formula != null );
      assertTrue((  "1 + 1" == formula ));
      assertTrue(( formula == ar.getFormula() ));
      ar = null;
    }

    public void test_AlgebraicRule_createWithMath()
    {
      ASTNode math = libsbml.parseFormula("1 + 1");
      AlgebraicRule ar = new  AlgebraicRule(2,4);
      ar.setMath(math);
      assertTrue( ar.getTypeCode() == libsbml.SBML_ALGEBRAIC_RULE );
      assertTrue( ar.getMetaId() == "" );
      assertTrue((  "1 + 1" == ar.getFormula() ));
      assertTrue( ar.getMath() != math );
      ar = null;
      math = null;
    }

    public void test_AlgebraicRule_createWithNS()
    {
      XMLNamespaces xmlns = new  XMLNamespaces();
      xmlns.add( "http://www.sbml.org", "testsbml");
      SBMLNamespaces sbmlns = new  SBMLNamespaces(2,3);
      sbmlns.addNamespaces(xmlns);
      AlgebraicRule r = new  AlgebraicRule(sbmlns);
      assertTrue( r.getTypeCode() == libsbml.SBML_ALGEBRAIC_RULE );
      assertTrue( r.getMetaId() == "" );
      assertTrue( r.getNotes() == null );
      assertTrue( r.getAnnotation() == null );
      assertTrue( r.getLevel() == 2 );
      assertTrue( r.getVersion() == 3 );
      assertTrue( (r).getNamespaces() != null );
      assertTrue( (r).getNamespaces().getLength() == 2 );
      (r) = null;
      xmlns = null;
      sbmlns = null;
    }

    public void test_AlgebraicRule_free_NULL()
    {
    }

  }
}
