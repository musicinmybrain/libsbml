/*
 * @file    TestXMLErrorC.java
 * @brief   XMLError unit tests, C version
 *
 * @author  Akiya Jouraku (Java conversion)
 * @author  Sarah Keating 
 * 
 * ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
 *
 * DO NOT EDIT THIS FILE.
 *
 * This file was generated automatically by converting the file located at
 * src/sbml/test/TestXMLErrorC.c
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

package org.sbml.libsbml.test.xml;

import org.sbml.libsbml.*;

import java.io.File;
import java.lang.AssertionError;

public class TestXMLErrorC {

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

  public void test_XMLError_accessWithNULL()
  {
    assertTrue( new  XMLError(0,null) == null );
    assertTrue( null.getCategory() == SBML_INT_MAX );
    assertTrue( null.getCategoryAsString().equals("") == true );
    assertTrue( null.getColumn() == 0 );
    assertTrue( null.getErrorId() == SBML_INT_MAX );
    assertTrue( null.getLine() == 0 );
    assertTrue( null.getMessage().equals("") == true );
    assertTrue( null.getSeverity() == SBML_INT_MAX );
    assertTrue( null.getSeverityAsString().equals("") == true );
    assertTrue( null.getShortMessage() == null );
    assertTrue( null.isError() == false );
    assertTrue( null.isFatal() == false );
    assertTrue( null.isInfo() == false );
    assertTrue( null.isWarning() == false );
    null.print(null);
  }

  public void test_XMLError_create_C()
  {
    XMLError error = new  XMLError();
    assertTrue( error != null );
    assertTrue( error.isInfo() == false );
    assertTrue( error.isWarning() == false );
    assertTrue( error.isError() == false );
    assertTrue( error.isFatal() == true );
    error = null;
    error = new  XMLError(12345, "My message");
    assertTrue( !error.getMessage().equals( "My message") == false );
    assertTrue( error.getErrorId() == 12345 );
    error = null;
  }

  public void test_XMLError_variablesAsStrings()
  {
    XMLError error = new  XMLError(1003, "");
    assertTrue( error.getErrorId() == 1003 );
    assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR );
    assertTrue(error.getSeverityAsString().equals( "Error"));
    assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_XML );
    assertTrue(error.getCategoryAsString().equals( "XML content"));
    error = null;
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
