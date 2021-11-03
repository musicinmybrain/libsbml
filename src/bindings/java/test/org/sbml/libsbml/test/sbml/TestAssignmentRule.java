/*
 * @file    TestAssignmentRule.java
 * @brief   AssignmentRule unit tests
 *
 * @author  Akiya Jouraku (Java conversion)
 * @author  Ben Bornstein 
 * 
 * ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
 *
 * DO NOT EDIT THIS FILE.
 *
 * This file was generated automatically by converting the file located at
 * src/sbml/test/TestAssignmentRule.c
 * using the conversion program dev/utilities/translateTests/translateTests.pl.
 * Any changes made here will be lost the next time the file is regenerated.
 *
 * -----------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright 2005-2010 California Institute of Technology.
 * Copyright 2002-2005 California Institute of Technology and
 *                     Japan Science and Technology Corporation.
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * -----------------------------------------------------------------------------
 */

package org.sbml.libsbml.test.sbml;

import org.sbml.libsbml.*;

import java.io.File;
import java.lang.AssertionError;

public class TestAssignmentRule {

  static void assertTrue(boolean condition) throws AssertionError
  {
    if (condition == true)
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertEquals(Object a, Object b) throws AssertionError
  {
    if ( (a == null) && (b == null) )
    {
      return;
    }
    else if ( (a == null) || (b == null) )
    {
      throw new AssertionError();
    }
    else if (a.equals(b))
    {
      return;
    }

    throw new AssertionError();
  }

  static void assertNotEquals(Object a, Object b) throws AssertionError
  {
    if ( (a == null) && (b == null) )
    {
      throw new AssertionError();
    }
    else if ( (a == null) || (b == null) )
    {
      return;
    }
    else if (a.equals(b))
    {
      throw new AssertionError();
    }
  }

  static void assertEquals(boolean a, boolean b) throws AssertionError
  {
    if ( a == b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertNotEquals(boolean a, boolean b) throws AssertionError
  {
    if ( a != b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertEquals(int a, int b) throws AssertionError
  {
    if ( a == b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertNotEquals(int a, int b) throws AssertionError
  {
    if ( a != b )
    {
      return;
    }
    throw new AssertionError();
  }
  private AssignmentRule AR;

  protected void setUp() throws Exception
  {
    AR = new  AssignmentRule(2,4);
    if (AR == null);
    {
    }
  }

  protected void tearDown() throws Exception
  {
    AR = null;
  }

  public void test_AssignmentRule_L2_create()
  {
    assertTrue( AR.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
    assertTrue( AR.getMetaId().equals("") == true );
    assertTrue( AR.getNotes() == null );
    assertTrue( AR.getAnnotation() == null );
    assertTrue( AR.getFormula().equals("") == true );
    assertTrue( AR.getMath() == null );
    assertTrue( AR.getVariable().equals("") == true );
    assertTrue( AR.getType() == libsbml.RULE_TYPE_SCALAR );
  }

  public void test_AssignmentRule_createWithFormula()
  {
    ASTNode math;
    String formula;
    AssignmentRule ar = new  AssignmentRule(2,4);
    ar.setVariable( "s");
    ar.setFormula( "1 + 1");
    assertTrue( ar.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
    assertTrue( ar.getMetaId().equals("") == true );
    assertTrue(ar.getVariable().equals( "s"));
    math = ar.getMath();
    assertTrue( math != null );
    formula = libsbml.formulaToString(math);
    assertTrue( formula != null );
    assertTrue(formula.equals( "1 + 1"));
    assertTrue(ar.getFormula().equals(formula));
    ar = null;
  }

  public void test_AssignmentRule_createWithMath()
  {
    ASTNode math = libsbml.parseFormula("1 + 1");
    AssignmentRule ar = new  AssignmentRule(2,4);
    ar.setVariable( "s");
    ar.setMath(math);
    assertTrue( ar.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
    assertTrue( ar.getMetaId().equals("") == true );
    assertTrue(ar.getVariable().equals( "s"));
    assertTrue(ar.getFormula().equals( "1 + 1"));
    assertTrue( !ar.getMath().equals(math) );
    ar = null;
    math = null;
  }

  public void test_AssignmentRule_createWithNS()
  {
    XMLNamespaces xmlns = new  XMLNamespaces();
    xmlns.add( "http://www.sbml.org", "testsbml");
    SBMLNamespaces sbmlns = new  SBMLNamespaces(2,1);
    sbmlns.addNamespaces(xmlns);
    AssignmentRule object = new  AssignmentRule(sbmlns);
    assertTrue( object.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
    assertTrue( object.getMetaId().equals("") == true );
    assertTrue( object.getNotes() == null );
    assertTrue( object.getAnnotation() == null );
    assertTrue( object.getLevel() == 2 );
    assertTrue( object.getVersion() == 1 );
    assertTrue( object.getNamespaces() != null );
    assertTrue( (object).getNamespaces().getLength() == 2 );
    (object) = null;
    xmlns = null;
    sbmlns = null;
  }

  public void test_AssignmentRule_free_NULL()
  {
  }

  public void test_AssignmentRule_setVariable()
  {
    String variable =  "x";
    AR.setVariable(variable);
    assertTrue(AR.getVariable().equals(variable));
    assertEquals( true, AR.isSetVariable() );
    if (AR.getVariable() == variable);
    {
    }
    AR.setVariable(AR.getVariable());
    assertTrue(AR.getVariable().equals(variable));
    AR.setVariable("");
    assertEquals( false, AR.isSetVariable() );
    if (AR.getVariable() != null);
    {
    }
  }

  public void test_AssignmentRule_unsetVariable()
  {
    String variable =  "x";
    AR.setVariable(variable);
    assertTrue(AR.getVariable().equals(variable));
    assertEquals( true, AR.isSetVariable() );
    AR.unsetVariable();
    assertEquals( false, AR.isSetVariable() );
    if (AR.getVariable() != null);
    {
    }
  }

  /**
   * Loads the SWIG-generated libSBML Java module when this class is
   * loaded, or reports a sensible diagnostic message about why it failed.
   */
  static
  {
    String varname;
    String shlibname;

    if (System.getProperty("mrj.version") != null)
    {
      varname = "DYLD_LIBRARY_PATH";    // We're on a Mac.
      shlibname = "libsbmlj.jnilib and/or libsbml.dylib";
    }
    else
    {
      varname = "LD_LIBRARY_PATH";      // We're not on a Mac.
      shlibname = "libsbmlj.so and/or libsbml.so";
    }

    try
    {
      System.loadLibrary("sbmlj");
      // For extra safety, check that the jar file is in the classpath.
      Class.forName("org.sbml.libsbml.libsbml");
    }
    catch (SecurityException e)
    {
      e.printStackTrace();
      System.err.println("Could not load the libSBML library files due to a"+
                         " security exception.\n");
      System.exit(1);
    }
    catch (UnsatisfiedLinkError e)
    {
      e.printStackTrace();
      System.err.println("Error: could not link with the libSBML library files."+
                         " It is likely\nyour " + varname +
                         " environment variable does not include the directories\n"+
                         "containing the " + shlibname + " library files.\n");
      System.exit(1);
    }
    catch (ClassNotFoundException e)
    {
      e.printStackTrace();
      System.err.println("Error: unable to load the file libsbmlj.jar."+
                         " It is likely\nyour -classpath option and CLASSPATH" +
                         " environment variable\n"+
                         "do not include the path to libsbmlj.jar.\n");
      System.exit(1);
    }
  }
}
