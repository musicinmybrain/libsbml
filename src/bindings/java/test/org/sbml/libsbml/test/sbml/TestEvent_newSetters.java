/*
 * @file    TestEvent_newSetters.java
 * @brief   Event unit tests for new set function API
 *
 * @author  Akiya Jouraku (Java conversion)
 * @author  Sarah Keating 
 * 
 * ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
 *
 * DO NOT EDIT THIS FILE.
 *
 * This file was generated automatically by converting the file located at
 * src/sbml/test/TestEvent_newSetters.c
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

public class TestEvent_newSetters {

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
  private Event E;

  protected void setUp() throws Exception
  {
    E = new  Event(2,4);
    if (E == null);
    {
    }
  }

  protected void tearDown() throws Exception
  {
    E = null;
  }

  public void test_Event_addEventAssignment1()
  {
    Event e = new  Event(2,2);
    EventAssignment ea = new  EventAssignment(2,2);
    int i = e.addEventAssignment(ea);
    assertTrue( i == libsbml.LIBSBML_INVALID_OBJECT );
    ea.setVariable( "f");
    i = e.addEventAssignment(ea);
    assertTrue( i == libsbml.LIBSBML_INVALID_OBJECT );
    ASTNode math = libsbml.parseFormula("a-n");
    ea.setMath(math);
    math = null;
    i = e.addEventAssignment(ea);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( e.getNumEventAssignments() == 1 );
    ea = null;
    e = null;
  }

  public void test_Event_addEventAssignment2()
  {
    Event e = new  Event(2,2);
    EventAssignment ea = new  EventAssignment(2,3);
    ea.setVariable( "f");
    ASTNode math = libsbml.parseFormula("a-n");
    ea.setMath(math);
    math = null;
    int i = e.addEventAssignment(ea);
    assertTrue( i == libsbml.LIBSBML_VERSION_MISMATCH );
    assertTrue( e.getNumEventAssignments() == 0 );
    ea = null;
    e = null;
  }

  public void test_Event_addEventAssignment3()
  {
    Event e = new  Event(2,2);
    int i = e.addEventAssignment(null);
    assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED );
    assertTrue( e.getNumEventAssignments() == 0 );
    e = null;
  }

  public void test_Event_addEventAssignment4()
  {
    Event e = new  Event(2,2);
    EventAssignment ea = new  EventAssignment(2,2);
    ea.setVariable( "c");
    ASTNode math = libsbml.parseFormula("a-n");
    ea.setMath(math);
    math = null;
    EventAssignment ea1 = new  EventAssignment(2,2);
    ea1.setVariable( "c");
    math = libsbml.parseFormula("a-n");
    ea1.setMath(math);
    math = null;
    int i = e.addEventAssignment(ea);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( e.getNumEventAssignments() == 1 );
    i = e.addEventAssignment(ea1);
    assertTrue( i == libsbml.LIBSBML_DUPLICATE_OBJECT_ID );
    assertTrue( e.getNumEventAssignments() == 1 );
    ea = null;
    ea1 = null;
    e = null;
  }

  public void test_Event_createEventAssignment()
  {
    Event e = new  Event(2,2);
    EventAssignment ea = e.createEventAssignment();
    assertTrue( e.getNumEventAssignments() == 1 );
    assertTrue( (ea).getLevel() == 2 );
    assertTrue( (ea).getVersion() == 2 );
    e = null;
  }

  public void test_Event_setDelay1()
  {
    ASTNode math1 = libsbml.parseFormula("0");
    Delay Delay = new  Delay(2,4);
    Delay.setMath(math1);
    int i = E.setDelay(Delay);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertNotEquals(E.getDelay(),null);
    assertEquals( true, E.isSetDelay() );
    i = E.unsetDelay();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, E.isSetDelay() );
    math1 = null;
    Delay = null;
  }

  public void test_Event_setDelay2()
  {
    ASTNode math1 = libsbml.parseFormula("0");
    Delay Delay = new  Delay(2,1);
    Delay.setMath(math1);
    int i = E.setDelay(Delay);
    assertTrue( i == libsbml.LIBSBML_VERSION_MISMATCH );
    assertEquals( false, E.isSetDelay() );
    i = E.unsetDelay();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    math1 = null;
    Delay = null;
  }

  public void test_Event_setId1()
  {
    String id =  "1e1";
    int i = E.setId(id);
    assertTrue( i == libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE );
    assertEquals( false, E.isSetId() );
  }

  public void test_Event_setId2()
  {
    String id =  "e1";
    int i = E.setId(id);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue(E.getId().equals(id));
    assertEquals( true, E.isSetId() );
    i = E.unsetId();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, E.isSetId() );
  }

  public void test_Event_setId3()
  {
    int i = E.setId("");
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, E.isSetId() );
  }

  public void test_Event_setName1()
  {
    String name =  "3Set_k2";
    int i = E.setName(name);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( true, E.isSetName() );
  }

  public void test_Event_setName2()
  {
    String name =  "Set k2";
    int i = E.setName(name);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue(E.getName().equals(name));
    assertEquals( true, E.isSetName() );
    i = E.unsetName();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, E.isSetName() );
  }

  public void test_Event_setName3()
  {
    int i = E.setName("");
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, E.isSetName() );
  }

  public void test_Event_setTimeUnits1()
  {
    String units =  "second";
    int i = E.setTimeUnits(units);
    assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE );
    assertEquals( false, E.isSetTimeUnits() );
  }

  public void test_Event_setTimeUnits2()
  {
    String units =  "second";
    Event e = new  Event(2,1);
    int i = e.setTimeUnits(units);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue(e.getTimeUnits().equals(units));
    assertEquals( true, e.isSetTimeUnits() );
    i = e.unsetTimeUnits();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, e.isSetTimeUnits() );
    e = null;
  }

  public void test_Event_setTimeUnits3()
  {
    String units =  "1second";
    Event e = new  Event(2,1);
    int i = e.setTimeUnits(units);
    assertTrue( i == libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE );
    assertEquals( false, e.isSetTimeUnits() );
    i = e.unsetTimeUnits();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, e.isSetTimeUnits() );
    e = null;
  }

  public void test_Event_setTimeUnits4()
  {
    Event e = new  Event(2,1);
    int i = e.setTimeUnits("");
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, e.isSetTimeUnits() );
    e = null;
  }

  public void test_Event_setTrigger1()
  {
    Trigger trigger = new  Trigger(2,1);
    ASTNode math = libsbml.parseFormula("true");
    trigger.setMath(math);
    math = null;
    int i = E.setTrigger(trigger);
    assertTrue( i == libsbml.LIBSBML_VERSION_MISMATCH );
    assertEquals( false, E.isSetTrigger() );
    trigger = null;
  }

  public void test_Event_setTrigger2()
  {
    ASTNode math1 = libsbml.parseFormula("0");
    Trigger trigger = new  Trigger(2,4);
    trigger.setMath(math1);
    int i = E.setTrigger(trigger);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertNotEquals(E.getTrigger(),null);
    assertEquals( true, E.isSetTrigger() );
    math1 = null;
    trigger = null;
  }

  public void test_Event_setUseValuesFromTriggerTime1()
  {
    Event e = new  Event(2,4);
    int i = e.setUseValuesFromTriggerTime(false);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( e.getUseValuesFromTriggerTime() == false );
    i = e.setUseValuesFromTriggerTime(true);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( e.getUseValuesFromTriggerTime() == true );
    e = null;
  }

  public void test_Event_setUseValuesFromTriggerTime2()
  {
    Event e = new  Event(2,2);
    int i = e.setUseValuesFromTriggerTime(false);
    assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE );
    e = null;
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
