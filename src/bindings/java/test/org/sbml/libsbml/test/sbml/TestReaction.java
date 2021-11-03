/*
 * @file    TestReaction.java
 * @brief   SBML Reaction unit tests
 *
 * @author  Akiya Jouraku (Java conversion)
 * @author  Ben Bornstein 
 * 
 * ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
 *
 * DO NOT EDIT THIS FILE.
 *
 * This file was generated automatically by converting the file located at
 * src/sbml/test/TestReaction.c
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

public class TestReaction {

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
  private Reaction R;

  protected void setUp() throws Exception
  {
    R = new  Reaction(2,4);
    if (R == null);
    {
    }
  }

  protected void tearDown() throws Exception
  {
    R = null;
  }

  public void test_Reaction_addModifierBySpecies()
  {
    Species s = new  Species(2,4);
    s.setId( "s");
    R.addModifier(s, "sr");
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 1 );
    SpeciesReference sr = R.getModifier(0);
    assertTrue(sr.getSpecies().equals( "s"));
    assertTrue(sr.getId().equals( "sr"));
    assertTrue( R.addModifier(s, "sr") == libsbml.LIBSBML_DUPLICATE_OBJECT_ID );
    assertTrue( R.getNumModifiers() == 1 );
    s = null;
  }

  public void test_Reaction_addProduct()
  {
    SpeciesReference sr = new  SpeciesReference(2,4);
    sr.setSpecies( "s");
    R.addProduct(sr);
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 1 );
    assertTrue( R.getNumModifiers() == 0 );
    sr = null;
  }

  public void test_Reaction_addProductBySpecies()
  {
    Species s = new  Species(2,4);
    s.setId( "s");
    R.addProduct(s,2.0, "sr",0);
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 1 );
    assertTrue( R.getNumModifiers() == 0 );
    SpeciesReference sr = R.getProduct(0);
    assertTrue(sr.getSpecies().equals( "s"));
    assertTrue( util_isEqual == 1 );
    assertTrue(sr.getId().equals( "sr"));
    assertTrue( sr.getConstant() == false );
    assertTrue( R.addProduct(s,1.0, "sr",0) == libsbml.LIBSBML_DUPLICATE_OBJECT_ID );
    assertTrue( R.getNumProducts() == 1 );
    s = null;
  }

  public void test_Reaction_addReactant()
  {
    SpeciesReference sr = new  SpeciesReference(2,4);
    sr.setSpecies( "s");
    R.addReactant(sr);
    assertTrue( R.getNumReactants() == 1 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 0 );
    sr = null;
  }

  public void test_Reaction_addReactantBySpecies()
  {
    Species s = new  Species(2,4);
    s.setId( "s");
    R.addReactant(s,2.0, "sr",0);
    assertTrue( R.getNumReactants() == 1 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 0 );
    SpeciesReference sr = R.getReactant(0);
    assertTrue(sr.getSpecies().equals( "s"));
    assertTrue( util_isEqual == 1 );
    assertTrue(sr.getId().equals( "sr"));
    assertTrue( sr.getConstant() == false );
    assertTrue( R.addReactant(s,1.0, "sr",0) == libsbml.LIBSBML_DUPLICATE_OBJECT_ID );
    s = null;
  }

  public void test_Reaction_compartment()
  {
    String name =  "Cell";
    Reaction r = new  Reaction(3,1);
    r.setCompartment(name);
    assertTrue(r.getCompartment().equals(name));
    assertEquals( true, r.isSetCompartment() );
    if (r.getCompartment() == name);
    {
    }
    r.setCompartment(r.getCompartment());
    assertTrue(r.getCompartment().equals(name));
    r.unsetCompartment();
    assertEquals( false, r.isSetCompartment() );
    if (r.getCompartment() != null);
    {
    }
    r = null;
  }

  public void test_Reaction_create()
  {
    assertTrue( R.getTypeCode() == libsbml.SBML_REACTION );
    assertTrue( R.getMetaId().equals("") == true );
    assertTrue( R.getNotes() == null );
    assertTrue( R.getAnnotation() == null );
    assertTrue( R.getId().equals("") == true );
    assertTrue( R.getName().equals("") == true );
    assertEquals(R.getKineticLaw(),null);
    assertTrue( R.getReversible() != false );
    assertTrue( R.getFast() == false );
    assertEquals( false, R.isSetId() );
    assertEquals( false, R.isSetName() );
    assertEquals( false, R.isSetKineticLaw() );
    assertEquals( false, R.isSetFast() );
    assertEquals( true, R.isSetReversible() );
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 0 );
  }

  public void test_Reaction_createWithNS()
  {
    XMLNamespaces xmlns = new  XMLNamespaces();
    xmlns.add( "http://www.sbml.org", "testsbml");
    SBMLNamespaces sbmlns = new  SBMLNamespaces(2,1);
    sbmlns.addNamespaces(xmlns);
    Reaction object = new  Reaction(sbmlns);
    assertTrue( object.getTypeCode() == libsbml.SBML_REACTION );
    assertTrue( object.getMetaId().equals("") == true );
    assertTrue( object.getNotes() == null );
    assertTrue( object.getAnnotation() == null );
    assertTrue( object.getLevel() == 2 );
    assertTrue( object.getVersion() == 1 );
    assertTrue( object.getNamespaces() != null );
    assertTrue( object.getNamespaces().getLength() == 2 );
    object = null;
    xmlns = null;
    sbmlns = null;
  }

  public void test_Reaction_fast()
  {
    R.setFast(true);
    assertTrue( R.isSetFast() == true );
    assertTrue( R.getFast() == true );
    R.unsetFast();
    assertTrue( R.isSetFast() == false );
    assertTrue( R.getFast() == true );
    R.setFast(false);
    assertTrue( R.isSetFast() == true );
    assertTrue( R.getFast() == false );
    R.unsetFast();
    assertTrue( R.isSetFast() == false );
    assertTrue( R.getFast() == false );
  }

  public void test_Reaction_free_NULL()
  {
  }

  public void test_Reaction_getProduct()
  {
    SpeciesReference sr1 = new  SpeciesReference(2,4);
    SpeciesReference sr2 = new  SpeciesReference(2,4);
    sr1.setSpecies( "P1");
    sr2.setSpecies( "P2");
    R.addProduct(sr1);
    R.addProduct(sr2);
    sr1 = null;
    sr2 = null;
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 2 );
    assertTrue( R.getNumModifiers() == 0 );
    sr1 = R.getProduct(0);
    sr2 = R.getProduct(1);
    assertTrue(sr1.getSpecies().equals( "P1"));
    assertTrue(sr2.getSpecies().equals( "P2"));
  }

  public void test_Reaction_getProductById()
  {
    SpeciesReference sr1 = new  SpeciesReference(2,4);
    sr1.setSpecies( "P1");
    SpeciesReference sr2 = new  SpeciesReference(2,4);
    sr2.setSpecies( "P1");
    R.addProduct(sr1);
    R.addProduct(sr2);
    assertTrue( R.getNumReactants() == 0 );
    assertTrue( R.getNumProducts() == 2 );
    assertTrue( R.getNumModifiers() == 0 );
    assertNotEquals(R.getProduct( "P1"),sr1);
    assertNotEquals(R.getProduct( "P2"),sr2);
    assertEquals(R.getProduct( "P3"),null);
    sr1 = null;
    sr2 = null;
  }

  public void test_Reaction_getReactant()
  {
    SpeciesReference sr1 = new  SpeciesReference(2,4);
    SpeciesReference sr2 = new  SpeciesReference(2,4);
    sr1.setSpecies( "R1");
    sr2.setSpecies( "R2");
    R.addReactant(sr1);
    R.addReactant(sr2);
    sr1 = null;
    sr2 = null;
    assertTrue( R.getNumReactants() == 2 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 0 );
    sr1 = R.getReactant(0);
    sr2 = R.getReactant(1);
    assertTrue(sr1.getSpecies().equals( "R1"));
    assertTrue(sr2.getSpecies().equals( "R2"));
  }

  public void test_Reaction_getReactantById()
  {
    SpeciesReference sr1 = new  SpeciesReference(2,4);
    sr1.setSpecies( "R1");
    SpeciesReference sr2 = new  SpeciesReference(2,4);
    sr2.setSpecies( "R2");
    R.addReactant(sr1);
    R.addReactant(sr2);
    assertTrue( R.getNumReactants() == 2 );
    assertTrue( R.getNumProducts() == 0 );
    assertTrue( R.getNumModifiers() == 0 );
    assertNotEquals(R.getReactant( "R1"),sr1);
    assertNotEquals(R.getReactant( "R2"),sr2);
    assertEquals(R.getReactant( "R3"),null);
    sr1 = null;
    sr2 = null;
  }

  public void test_Reaction_removeProduct()
  {
    SpeciesReference o1, o2, o3;
    o1 = R.createProduct();
    o2 = R.createProduct();
    o3 = R.createProduct();
    o3.setSpecies("test");
    assertTrue( R.removeProduct(0).equals(o1) );
    assertTrue( R.getNumProducts() == 2 );
    assertTrue( R.removeProduct(0).equals(o2) );
    assertTrue( R.getNumProducts() == 1 );
    assertTrue( R.removeProduct("test").equals(o3) );
    assertTrue( R.getNumProducts() == 0 );
    o1 = null;
    o2 = null;
    o3 = null;
  }

  public void test_Reaction_removeReactant()
  {
    SpeciesReference o1, o2, o3;
    o1 = R.createReactant();
    o2 = R.createReactant();
    o3 = R.createReactant();
    o3.setSpecies("test");
    assertTrue( R.removeReactant(0).equals(o1) );
    assertTrue( R.getNumReactants() == 2 );
    assertTrue( R.removeReactant(0).equals(o2) );
    assertTrue( R.getNumReactants() == 1 );
    assertTrue( R.removeReactant("test").equals(o3) );
    assertTrue( R.getNumReactants() == 0 );
    o1 = null;
    o2 = null;
    o3 = null;
  }

  public void test_Reaction_reversible()
  {
    assertTrue( R.isSetReversible() == true );
    assertTrue( R.getReversible() == true );
    R.setReversible(true);
    assertTrue( R.isSetReversible() == true );
    assertTrue( R.getReversible() == true );
    int ret = R.unsetReversible();
    assertTrue( ret == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE );
    assertTrue( R.isSetReversible() == true );
    assertTrue( R.getReversible() == true );
    R.setReversible(false);
    assertTrue( R.isSetReversible() == true );
    assertTrue( R.getReversible() == false );
    ret = R.unsetReversible();
    assertTrue( ret == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE );
    assertTrue( R.isSetReversible() == true );
    assertTrue( R.getReversible() == true );
  }

  public void test_Reaction_setId()
  {
    String id =  "J1";
    R.setId(id);
    assertTrue(R.getId().equals(id));
    assertEquals( true, R.isSetId() );
    if (R.getId() == id);
    {
    }
    R.setId(R.getId());
    assertTrue(R.getId().equals(id));
    R.setId("");
    assertEquals( false, R.isSetId() );
    if (R.getId() != null);
    {
    }
  }

  public void test_Reaction_setName()
  {
    String name =  "MapK_Cascade";
    R.setName(name);
    assertTrue(R.getName().equals(name));
    assertEquals( true, R.isSetName() );
    if (R.getName() == name);
    {
    }
    R.setName(R.getName());
    assertTrue(R.getName().equals(name));
    R.setName("");
    assertEquals( false, R.isSetName() );
    if (R.getName() != null);
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
