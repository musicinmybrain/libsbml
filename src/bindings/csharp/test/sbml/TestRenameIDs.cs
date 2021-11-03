///  @file    TestRenameIDs.cs
///  @brief   RenameIDs unit tests
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Lucian Smith 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestRenameIDs.cpp
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

  public class TestRenameIDs {
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


    public void test_RenameIDs()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == NULL || d.getModel() == null);
      {
      }
      SBase obj;
      List allElements = d.getAllElements();
      assertTrue( obj != null );
      obj.renameSIdRefs("comp", "comp_new");
      obj.renameSIdRefs("C", "C_new");
      obj.renameSIdRefs("conv", "conv_new");
      obj.renameSIdRefs("b", "b_new");
      obj.renameSIdRefs("b2", "b2_new");
      obj.renameSIdRefs("x", "x_new");
      obj.renameSIdRefs("y"_COMMA_ "y_new"); //The 'y' here in the function definition not actually an SIdso this should have no effect.obj.renameUnitSIdRefs("volume"_COMMA_ "volume_new");
      obj.renameUnitSIdRefs("substance", "substance_new");
      obj.renameUnitSIdRefs("item", "item_new");
      obj.renameUnitSIdRefs("second", "second_new");
      obj.renameUnitSIdRefs("litre", "litre_new");
      obj.renameUnitSIdRefs("candela", "candela_new");
      obj.renameUnitSIdRefs("farad", "farad_new");
      obj.renameUnitSIdRefs("coulomb", "coulomb_new");
    }
    obj = d.getElementByMetaId("meta21");
    assertTrue( obj != null );
    string xml = obj.toSBML();
    assertTrue( xmlstr.find("y_new") == string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    obj = d.getElementByMetaId("meta4");
    assertTrue( obj != null );
    Compartment compartment = (Compartment) obj;
    assertTrue( compartment.getUnits() ==  "volume_new" );
    obj = d.getElementByMetaId("meta6");
    assertTrue( obj != null );
    Species sp = (Species) obj;
    assertTrue( sp.getSubstanceUnits() ==  "substance_new" );
    assertTrue( sp.getConversionFactor() ==  "conv_new" );
    assertTrue( sp.getCompartment() ==  "comp_new" );
    obj = d.getElementByMetaId("meta11");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("x_new") == string::npos );
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("b2_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    obj = d.getElementByMetaId("meta28");
    assertTrue( obj != null );
    LocalParameter lp = (LocalParameter) obj;
    assertTrue( lp.getUnits() ==  "volume_new" );
    obj = d.getElementByMetaId("meta10");
    assertTrue( obj != null );
    SpeciesReference sr = (SpeciesReference) obj;
    assertTrue( sr.getSpecies() ==  "b_new" );
    obj = d.getElementByMetaId("meta10");
    assertTrue( obj != null );
    ModifierSpeciesReference msr = (ModifierSpeciesReference) obj;
    assertTrue( msr.getSpecies() ==  "b_new" );
    obj = d.getElementByMetaId("meta8");
    assertTrue( obj != null );
    Reaction rxn = (Reaction) obj;
    assertTrue( rxn.getCompartment() ==  "comp_new" );
    obj = d.getElementByMetaId("meta18");
    assertTrue( obj != null );
    Parameter p = (Parameter) obj;
    assertTrue( p.getUnits() ==  "volume_new" );
    obj = d.getElementByMetaId("meta14");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    obj = d.getElementByMetaId("meta16");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    EventAssignment ea = (EventAssignment) obj;
    assertTrue( ea.getVariable() ==  "b_new" );
    obj = d.getElementByMetaId("meta17");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    obj = d.getElementByMetaId("meta19");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    obj = d.getElementByMetaId("meta23");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("x_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    InitialAssignment ia = (InitialAssignment) obj;
    assertTrue( ia.getSymbol() ==  "b_new" );
    obj = d.getElementByMetaId("meta25");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    RateRule rr = (RateRule) obj;
    assertTrue( rr.getVariable() ==  "x_new" );
    obj = d.getElementByMetaId("meta26");
    assertTrue( obj != null );
    xml = obj.toSBML();
    xmlstr = xml;
    assertTrue( xmlstr.find("b_new") != string::npos );
    assertTrue( xmlstr.find("volume_new") != string::npos );
    AssignmentRule ar = (AssignmentRule) obj;
    assertTrue( ar.getVariable() ==  "C_new" );
    obj = d.getElementByMetaId("meta2");
    assertTrue( obj != null );
    Model mod = (Model) obj;
    assertTrue( mod.getConversionFactor() ==  "conv_new" );
    assertTrue( mod.getSubstanceUnits() ==  "item_new" );
    assertTrue( mod.getTimeUnits() ==  "second_new" );
    assertTrue( mod.getVolumeUnits() ==  "litre_new" );
    assertTrue( mod.getAreaUnits() ==  "candela_new" );
    assertTrue( mod.getLengthUnits() ==  "farad_new" );
    assertTrue( mod.getExtentUnits() ==  "coulomb_new" );
    d = null;
    allElements = null;
  }

  }
}
