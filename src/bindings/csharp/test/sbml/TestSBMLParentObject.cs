///  @file    TestSBMLParentObject.cs
///  @brief   SBML parent object unit tests
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Sarah Keating 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestSBMLParentObject.cpp
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

  public class TestSBMLParentObject {
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


    public void test_AlgebraicRule_parent_create()
    {
      Model m = new Model(2,4);
      AlgebraicRule r = m.createAlgebraicRule();
      ListOf lo = m.getListOfRules();
      assertTrue( lo == m.getRule(0).getParentSBMLObject() );
      assertTrue( lo == r.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_AssignmentRule_parent_create()
    {
      Model m = new Model(2,4);
      AssignmentRule r = m.createAssignmentRule();
      ListOf lo = m.getListOfRules();
      assertTrue( lo == m.getRule(0).getParentSBMLObject() );
      assertTrue( lo == r.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_CompartmentType_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument(2,4);
      Model m = d.createModel();
      CompartmentType c = m.createCompartmentType();
      CompartmentType c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_CompartmentType_parent_add()
    {
      CompartmentType ct = new CompartmentType(2,4);
      Model m = new Model(2,4);
      ct.setId("ct");
      m.addCompartmentType(ct);
      ct = null;
      ListOf lo = m.getListOfCompartmentTypes();
      assertTrue( lo == m.getCompartmentType(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_CompartmentType_parent_create()
    {
      Model m = new Model(2,4);
      CompartmentType ct = m.createCompartmentType();
      ListOf lo = m.getListOfCompartmentTypes();
      assertTrue( lo == m.getCompartmentType(0).getParentSBMLObject() );
      assertTrue( lo == ct.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_CompartmentType_parent_mismatch()
    {
      CompartmentType ct = new CompartmentType(2,4);
      Model m = new Model(3,1);
      ct.setId("ct");
      int success = m.addCompartmentType(ct);
      assertTrue( success == libsbml.LIBSBML_LEVEL_MISMATCH );
      ct = null;
      m = null;
    }

    public void test_Compartment_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      Compartment c = m.createCompartment();
      Compartment c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Compartment_parent_add()
    {
      Compartment c = new Compartment(2,4);
      c.setId("c");
      Model m = new Model(2,4);
      m.addCompartment(c);
      c = null;
      ListOf lo = m.getListOfCompartments();
      assertTrue( lo == m.getCompartment(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Compartment_parent_create()
    {
      Model m = new Model(2,4);
      Compartment c = m.createCompartment();
      ListOf lo = m.getListOfCompartments();
      assertTrue( lo == m.getCompartment(0).getParentSBMLObject() );
      assertTrue( lo == c.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Compartment_parent_mismatch()
    {
      Compartment c = new Compartment(2,3);
      c.setId("c");
      Model m = new Model(2,4);
      int success = m.addCompartment(c);
      assertTrue( success == libsbml.LIBSBML_VERSION_MISMATCH );
      c = null;
      m = null;
    }

    public void test_Constraint_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      Constraint c = m.createConstraint();
      Constraint c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Constraint_parent_add()
    {
      Constraint ct = new Constraint(2,4);
      Model m = new Model(2,4);
      ASTNode math = libsbml.parseFormula("a-k");
      ct.setMath(math);
      math = null;
      m.addConstraint(ct);
      ct = null;
      ListOf lo = m.getListOfConstraints();
      assertTrue( lo == m.getConstraint(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Constraint_parent_create()
    {
      Model m = new Model(2,4);
      Constraint ct = m.createConstraint();
      ListOf lo = m.getListOfConstraints();
      assertTrue( lo == m.getConstraint(0).getParentSBMLObject() );
      assertTrue( lo == ct.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Constraint_parent_mismatch()
    {
      Constraint ct = null;
      Model m = new Model(2,4);
      int success = m.addConstraint(ct);
      assertTrue( success == libsbml.LIBSBML_OPERATION_FAILED );
      ct = null;
      m = null;
    }

    public void test_Delay_parent_add()
    {
      Delay d = new Delay(2,4);
      Event e = new Event(2,4);
      ASTNode math = libsbml.parseFormula("1");
      d.setMath(math);
      math = null;
      e.setDelay(d);
      d = null;
      assertTrue( e == e.getDelay().getParentSBMLObject() );
      e = null;
    }

    public void test_Delay_parent_mismatch()
    {
      Event e = new Event(3,1);
      Delay d = null;
      int success = e.setDelay(d);
      assertTrue( success == libsbml.LIBSBML_OPERATION_SUCCESS );
      e = null;
      d = null;
    }

    public void test_EventAssignment_parent_add()
    {
      Event e = new Event(2,4);
      EventAssignment ea = new EventAssignment(2,4);
      ea.setVariable("c");
      ASTNode math = libsbml.parseFormula("K+L");
      ea.setMath(math);
      math = null;
      e.addEventAssignment(ea);
      ea = null;
      ListOf lo = e.getListOfEventAssignments();
      assertTrue( lo == e.getEventAssignment(0).getParentSBMLObject() );
      assertTrue( e == lo.getParentSBMLObject() );
      e = null;
    }

    public void test_EventAssignment_parent_create()
    {
      Event e = new Event(2,4);
      EventAssignment ea = e.createEventAssignment();
      ListOf lo = e.getListOfEventAssignments();
      assertTrue( lo == e.getEventAssignment(0).getParentSBMLObject() );
      assertTrue( lo == ea.getParentSBMLObject() );
      assertTrue( e == lo.getParentSBMLObject() );
      e = null;
    }

    public void test_EventAssignment_parent_create_model()
    {
      Model m = new Model(2,4);
      Event e = m.createEvent();
      EventAssignment ea = m.createEventAssignment();
      ListOf lo = e.getListOfEventAssignments();
      assertTrue( lo == e.getEventAssignment(0).getParentSBMLObject() );
      assertTrue( lo == ea.getParentSBMLObject() );
      assertTrue( e == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_EventAssignment_parent_mismatch()
    {
      SBMLNamespaces sbmlns = new SBMLNamespaces ( 3,1 );
      Event e = new Event(sbmlns);
      sbmlns.addNamespace("http://www.sbml.org/sbml/level3/version1/comp/version1", "comp");
      EventAssignment ea = new EventAssignment(sbmlns);
      ea.setVariable("c");
      ASTNode math = libsbml.parseFormula("K+L");
      ea.setMath(math);
      math = null;
      int success = e.addEventAssignment(ea);
      assertTrue( success == libsbml.LIBSBML_NAMESPACES_MISMATCH );
      e = null;
      ea = null;
    }

    public void test_Event_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument(2,4);
      Model m = d.createModel();
      Event c = m.createEvent();
      EventAssignment ea = c.createEventAssignment();
      Trigger t = new Trigger(2,4);
      ASTNode math = new ASTNode();
      t.setMath(math);
      Delay dy = new Delay(2,4);
      dy.setMath(math);
      c.setTrigger(t);
      c.setDelay(dy);
      assertTrue( c.getAncestorOfType(libsbml.SBML_MODEL) == m );
      assertTrue( c.getTrigger().getParentSBMLObject() == c );
      assertEquals(c.getDelay().getSBMLDocument(),d);
      assertTrue( ea.getAncestorOfType(libsbml.SBML_EVENT) == c );
      Event c1 = c.clone();
      d = null;
      t = null;
      dy = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      assertTrue( c1.getEventAssignment(0).getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getEventAssignment(0).getAncestorOfType(libsbml.SBML_EVENT) == c1 );
      assertTrue( c1.getEventAssignment(0).getParentSBMLObject() != null );
      assertEquals(c1.getEventAssignment(0).getSBMLDocument(),null);
      assertTrue( c1.getTrigger().getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getTrigger().getAncestorOfType(libsbml.SBML_EVENT) == c1 );
      assertTrue( c1.getTrigger().getParentSBMLObject() != null );
      assertEquals(c1.getTrigger().getSBMLDocument(),null);
      assertTrue( c1.getDelay().getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getDelay().getAncestorOfType(libsbml.SBML_EVENT) == c1 );
      assertTrue( c1.getDelay().getParentSBMLObject() != null );
      assertEquals(c1.getDelay().getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Event_parent_add()
    {
      Event e = new Event(2,4);
      Trigger t = new Trigger(2,4);
      ASTNode math = libsbml.parseFormula("true");
      t.setMath(math);
      math = null;
      e.setTrigger(t);
      e.createEventAssignment();
      Model m = new Model(2,4);
      m.addEvent(e);
      ListOf lo = m.getListOfEvents();
      assertTrue( lo == m.getEvent(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      e = null;
      t = null;
      m = null;
    }

    public void test_Event_parent_create()
    {
      Model m = new Model(2,4);
      Event e = m.createEvent();
      ListOf lo = m.getListOfEvents();
      assertTrue( lo == m.getEvent(0).getParentSBMLObject() );
      assertTrue( lo == e.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Event_parent_mismatch()
    {
      Event e = new Event(3,1);
      Model m = new Model(3,1);
      int success = m.addEvent(e);
      assertTrue( success == libsbml.LIBSBML_INVALID_OBJECT );
      e = null;
      m = null;
    }

    public void test_FunctionDefinition_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      FunctionDefinition c = m.createFunctionDefinition();
      FunctionDefinition c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_FunctionDefinition_parent_add()
    {
      FunctionDefinition fd = new FunctionDefinition(2,4);
      Model m = new Model(2,4);
      fd.setId("fd");
      ASTNode math = libsbml.parseFormula("l");
      fd.setMath(math);
      math = null;
      m.addFunctionDefinition(fd);
      fd = null;
      ListOf lo = m.getListOfFunctionDefinitions();
      assertTrue( lo == m.getFunctionDefinition(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_FunctionDefinition_parent_create()
    {
      Model m = new Model(2,4);
      FunctionDefinition fd = m.createFunctionDefinition();
      ListOf lo = m.getListOfFunctionDefinitions();
      assertTrue( lo == m.getFunctionDefinition(0).getParentSBMLObject() );
      assertTrue( lo == fd.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_InitialAssignment_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      InitialAssignment c = m.createInitialAssignment();
      InitialAssignment c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_InitialAssignment_parent_add()
    {
      InitialAssignment ia = new InitialAssignment(2,4);
      Model m = new Model(2,4);
      ia.setSymbol("c");
      ASTNode math = libsbml.parseFormula("9");
      ia.setMath(math);
      math = null;
      m.addInitialAssignment(ia);
      ia = null;
      ListOf lo = m.getListOfInitialAssignments();
      assertTrue( lo == m.getInitialAssignment(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_InitialAssignment_parent_create()
    {
      Model m = new Model(2,4);
      InitialAssignment ia = m.createInitialAssignment();
      ListOf lo = m.getListOfInitialAssignments();
      assertTrue( lo == m.getInitialAssignment(0).getParentSBMLObject() );
      assertTrue( lo == ia.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_KineticLaw_Parameter_parent_add()
    {
      KineticLaw kl = new KineticLaw(2,4);
      Parameter p = new Parameter(2,4);
      p.setId("jake");
      kl.addParameter(p);
      p = null;
      assertTrue( kl.getNumParameters() == 1 );
      assertTrue( kl.getParameter(0).getId() ==  "jake" );
      ListOfParameters lop = kl.getListOfParameters();
      assertTrue( kl == lop.getParentSBMLObject() );
      assertTrue( lop == kl.getParameter(0).getParentSBMLObject() );
      kl = null;
    }

    public void test_KineticLaw_Parameter_parent_create()
    {
      KineticLaw kl = new KineticLaw(2,4);
      Parameter p = kl.createParameter();
      assertTrue( kl.getNumParameters() == 1 );
      ListOfParameters lop = kl.getListOfParameters();
      assertTrue( kl == lop.getParentSBMLObject() );
      assertTrue( lop == p.getParentSBMLObject() );
      assertTrue( lop == kl.getParameter(0).getParentSBMLObject() );
      kl = null;
    }

    public void test_KineticLaw_Parameter_parent_create_model()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      KineticLaw kl = m.createKineticLaw();
      Parameter p = m.createKineticLawParameter();
      assertTrue( kl.getNumParameters() == 1 );
      ListOfParameters lop = kl.getListOfParameters();
      assertTrue( r == kl.getParentSBMLObject() );
      assertTrue( kl == lop.getParentSBMLObject() );
      assertTrue( lop == p.getParentSBMLObject() );
      assertTrue( lop == kl.getParameter(0).getParentSBMLObject() );
      m = null;
    }

    public void test_KineticLaw_parent_NULL()
    {
      Reaction r = new Reaction(2,4);
      KineticLaw kl = r.createKineticLaw();
      Parameter p = kl.createParameter();
      assertTrue( r == kl.getParentSBMLObject() );
      assertTrue( r == p.getAncestorOfType(libsbml.SBML_REACTION) );
      assertTrue( kl == p.getAncestorOfType(libsbml.SBML_KINETIC_LAW) );
      KineticLaw kl1 = kl.clone();
      assertTrue( kl1.getParentSBMLObject() == null );
      assertTrue( kl1.getParameter(0).getAncestorOfType(libsbml.SBML_REACTION) == null );
      assertTrue( kl1 == kl1.getParameter(0).getAncestorOfType(libsbml.SBML_KINETIC_LAW) );
      r = null;
      kl1 = null;
    }

    public void test_KineticLaw_parent_add()
    {
      KineticLaw kl = new KineticLaw(2,4);
      ASTNode math = libsbml.parseFormula("a");
      kl.setMath(math);
      math = null;
      Reaction r = new Reaction(2,4);
      r.setKineticLaw(kl);
      assertTrue( r == r.getKineticLaw().getParentSBMLObject() );
      r = null;
      kl = null;
    }

    public void test_KineticLaw_parent_create()
    {
      Reaction r = new Reaction(2,4);
      KineticLaw kl = r.createKineticLaw();
      assertTrue( r == kl.getParentSBMLObject() );
      r = null;
    }

    public void test_KineticLaw_parent_create_model()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      KineticLaw kl = r.createKineticLaw();
      assertTrue( r == kl.getParentSBMLObject() );
      assertTrue( r == r.getKineticLaw().getParentSBMLObject() );
      m = null;
    }

    public void test_KineticLaw_parent_mismatch()
    {
      KineticLaw kl = new KineticLaw(2,3);
      ASTNode math = libsbml.parseFormula("true");
      kl.setMath(math);
      math = null;
      Reaction r = new Reaction(2,4);
      int success = r.setKineticLaw(kl);
      assertTrue( success == libsbml.LIBSBML_VERSION_MISMATCH );
      r = null;
      kl = null;
    }

    public void test_Model_parent_add()
    {
      SBMLDocument d = new SBMLDocument(2,4);
      Model m = new Model(2,4);
      d.setModel(m);
      assertTrue( d == d.getModel().getParentSBMLObject() );
      d = null;
      m = null;
    }

    public void test_Model_parent_create()
    {
      SBMLDocument d = new SBMLDocument(2,4);
      Model m = d.createModel();
      assertTrue( d == m.getParentSBMLObject() );
      d = null;
    }

    public void test_Model_parent_mismatch()
    {
      SBMLNamespaces sbmlns = new SBMLNamespaces ( 3,1 );
      SBMLDocument d = new SBMLDocument(sbmlns);
      sbmlns.addNamespace("http://www.sbml.org/sbml/level3/version1/comp/version1", "comp");
      Model m = new Model(sbmlns);
      int success = d.setModel(m);
      assertTrue( success == libsbml.LIBSBML_NAMESPACES_MISMATCH );
      d = null;
      m = null;
    }

    public void test_Parameter_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      Parameter c = m.createParameter();
      Parameter c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Parameter_parent_add()
    {
      Parameter ia = new Parameter(2,4);
      Model m = new Model(2,4);
      ia.setId("p");
      m.addParameter(ia);
      ia = null;
      ListOf lo = m.getListOfParameters();
      assertTrue( lo == m.getParameter(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Parameter_parent_create()
    {
      Model m = new Model(2,4);
      Parameter p = m.createParameter();
      ListOf lo = m.getListOfParameters();
      assertTrue( lo == m.getParameter(0).getParentSBMLObject() );
      assertTrue( lo == p.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Priority_parent_mismatch()
    {
      Event e = new Event(3,1);
      Priority p = Priority(3,1);
      ASTNode math = libsbml.parseFormula("K+L");
      p.setMath(math);
      math = null;
      int success = e.setPriority(p);
      assertTrue( success == libsbml.LIBSBML_OPERATION_SUCCESS );
      success = e.setPriority(e.getPriority());
      assertTrue( success == libsbml.LIBSBML_OPERATION_SUCCESS );
      e = null;
      p = null;
    }

    public void test_RateRule_parent_create()
    {
      Model m = new Model(2,4);
      RateRule r = m.createRateRule();
      ListOf lo = m.getListOfRules();
      assertTrue( lo == m.getRule(0).getParentSBMLObject() );
      assertTrue( lo == r.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Reaction_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      Reaction c = m.createReaction();
      SpeciesReference sr = c.createReactant();
      KineticLaw kl = c.createKineticLaw();
      assertTrue( c.getAncestorOfType(libsbml.SBML_MODEL) == m );
      assertEquals(c.getSBMLDocument(),d);
      assertTrue( sr.getAncestorOfType(libsbml.SBML_REACTION) == c );
      assertTrue( kl.getAncestorOfType(libsbml.SBML_REACTION) == c );
      Reaction c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      SpeciesReference sr1 = c1.getReactant(0);
      assertTrue( sr1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( sr1.getAncestorOfType(libsbml.SBML_REACTION) == c1 );
      assertEquals(sr1.getSBMLDocument(),null);
      assertTrue( c1.getKineticLaw().getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getKineticLaw().getAncestorOfType(libsbml.SBML_REACTION) == c1 );
      assertEquals(c1.getKineticLaw().getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Reaction_parent_add()
    {
      Reaction ia = new Reaction(2,4);
      Model m = new Model(2,4);
      ia.setId("k");
      m.addReaction(ia);
      ia = null;
      ListOf lo = m.getListOfReactions();
      assertTrue( lo == m.getReaction(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Reaction_parent_create()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      ListOf lo = m.getListOfReactions();
      assertTrue( lo == m.getReaction(0).getParentSBMLObject() );
      assertTrue( lo == r.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Rule_parent_add()
    {
      Rule ia = new RateRule(2,4);
      ia.setVariable("a");
      ASTNode math = libsbml.parseFormula("9");
      ia.setMath(math);
      math = null;
      Model m = new Model(2,4);
      m.addRule(ia);
      ia = null;
      ListOf lo = m.getListOfRules();
      assertTrue( lo == m.getRule(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_SpeciesReference_Modifier_parent_add()
    {
      ModifierSpeciesReference sr = new ModifierSpeciesReference(2,4);
      sr.setSpecies("s");
      Reaction r = new Reaction(2,4);
      r.addModifier(sr);
      sr = null;
      ListOf lo = r.getListOfModifiers();
      assertTrue( lo == r.getModifier(0).getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Modifier_parent_create()
    {
      Reaction r = new Reaction(2,4);
      ModifierSpeciesReference sr = r.createModifier();
      ListOf lo = r.getListOfModifiers();
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( lo == r.getModifier(0).getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Modifier_parent_create_model()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      ModifierSpeciesReference sr = m.createModifier();
      ListOf lo = r.getListOfModifiers();
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( lo == r.getModifier(0).getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_SpeciesReference_Product_parent_add()
    {
      SpeciesReference sr = new SpeciesReference(2,4);
      Reaction r = new Reaction(2,4);
      sr.setSpecies("p");
      r.addProduct(sr);
      sr = null;
      ListOf lo = r.getListOfProducts();
      assertTrue( lo == r.getProduct(0).getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Product_parent_create()
    {
      Reaction r = new Reaction(2,4);
      SpeciesReference sr = r.createProduct();
      ListOf lo = r.getListOfProducts();
      assertTrue( lo == r.getProduct(0).getParentSBMLObject() );
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Product_parent_create_model()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      SpeciesReference sr = m.createProduct();
      ListOf lo = r.getListOfProducts();
      assertTrue( lo == r.getProduct(0).getParentSBMLObject() );
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_SpeciesReference_Reactant_parent_add()
    {
      SpeciesReference sr = new SpeciesReference(2,4);
      Reaction r = new Reaction(2,4);
      sr.setSpecies("s");
      r.addReactant(sr);
      sr = null;
      ListOf lo = r.getListOfReactants();
      assertTrue( lo == r.getReactant(0).getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Reactant_parent_create()
    {
      Reaction r = new Reaction(2,4);
      SpeciesReference sr = r.createReactant();
      ListOf lo = r.getListOfReactants();
      assertTrue( lo == r.getReactant(0).getParentSBMLObject() );
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      r = null;
    }

    public void test_SpeciesReference_Reactant_parent_create_model()
    {
      Model m = new Model(2,4);
      Reaction r = m.createReaction();
      SpeciesReference sr = m.createReactant();
      ListOf lo = r.getListOfReactants();
      assertTrue( lo == r.getReactant(0).getParentSBMLObject() );
      assertTrue( lo == sr.getParentSBMLObject() );
      assertTrue( r == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_SpeciesType_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument(2,4);
      Model m = d.createModel();
      SpeciesType c = m.createSpeciesType();
      SpeciesType c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_SpeciesType_parent_add()
    {
      SpeciesType ia = new SpeciesType(2,4);
      ia.setId("s");
      Model m = new Model(2,4);
      m.addSpeciesType(ia);
      ia = null;
      ListOf lo = m.getListOfSpeciesTypes();
      assertTrue( lo == m.getSpeciesType(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_SpeciesType_parent_create()
    {
      Model m = new Model(2,4);
      SpeciesType st = m.createSpeciesType();
      ListOf lo = m.getListOfSpeciesTypes();
      assertTrue( lo == m.getSpeciesType(0).getParentSBMLObject() );
      assertTrue( lo == st.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Species_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      Species c = m.createSpecies();
      Species c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      c1 = null;
    }

    public void test_Species_parent_add()
    {
      Species ia = new Species(2,4);
      ia.setId("s");
      ia.setCompartment("c");
      Model m = new Model(2,4);
      m.addSpecies(ia);
      ia = null;
      ListOf lo = m.getListOfSpecies();
      assertTrue( lo == m.getSpecies(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Species_parent_create()
    {
      Model m = new Model(2,4);
      Species s = m.createSpecies();
      ListOf lo = m.getListOfSpecies();
      assertTrue( lo == s.getParentSBMLObject() );
      assertTrue( lo == m.getSpecies(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_StoichiometryMath_parent_add()
    {
      StoichiometryMath m = new StoichiometryMath(2,4);
      ASTNode math = libsbml.parseFormula("1");
      m.setMath(math);
      math = null;
      SpeciesReference sr = new SpeciesReference(2,4);
      sr.setStoichiometryMath(m);
      m = null;
      assertTrue( sr == sr.getStoichiometryMath().getParentSBMLObject() );
      sr = null;
    }

    public void test_StoichiometryMath_parent_mismatch()
    {
      StoichiometryMath m = new StoichiometryMath(2,4);
      SpeciesReference sr = new SpeciesReference(2,4);
      int success = sr.setStoichiometryMath(m);
      assertTrue( success == libsbml.LIBSBML_INVALID_OBJECT );
      sr = null;
      m = null;
    }

    public void test_Trigger_parent_add()
    {
      Trigger d = new Trigger(2,4);
      ASTNode math = libsbml.parseFormula("false");
      d.setMath(math);
      math = null;
      Event e = new Event(2,4);
      e.setTrigger(d);
      d = null;
      assertTrue( e == e.getTrigger().getParentSBMLObject() );
      e = null;
    }

    public void test_Trigger_parent_mismatch()
    {
      Event e = new Event(3,1);
      Trigger t = new Trigger(2,4);
      ASTNode math = libsbml.parseFormula("true");
      t.setMath(math);
      math = null;
      int success = e.setTrigger(t);
      assertTrue( success == libsbml.LIBSBML_LEVEL_MISMATCH );
      e = null;
      t = null;
    }

    public void test_UnitDefinition_parent_NULL()
    {
      SBMLDocument d = new SBMLDocument();
      Model m = d.createModel();
      UnitDefinition c = m.createUnitDefinition();
      Unit u = c.createUnit();
      assertTrue( u.getAncestorOfType(libsbml.SBML_UNIT_DEFINITION) == c );
      UnitDefinition c1 = c.clone();
      d = null;
      assertTrue( c1.getAncestorOfType(libsbml.SBML_MODEL) == null );
      assertTrue( c1.getParentSBMLObject() == null );
      assertEquals(c1.getSBMLDocument(),null);
      assertTrue( c1.getUnit(0).getAncestorOfType(libsbml.SBML_UNIT_DEFINITION) == c1 );
      assertTrue( c1.getUnit(0).getParentSBMLObject() != null );
      assertEquals(c1.getUnit(0).getSBMLDocument(),null);
      c1 = null;
    }

    public void test_UnitDefinition_parent_add()
    {
      UnitDefinition ia = new UnitDefinition(2,4);
      Model m = new Model(2,4);
      ia.setId("u");
      ia.createUnit();
      m.addUnitDefinition(ia);
      ia = null;
      ListOf lo = m.getListOfUnitDefinitions();
      assertTrue( lo == m.getUnitDefinition(0).getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_UnitDefinition_parent_create()
    {
      Model m = new Model(2,4);
      UnitDefinition ud = m.createUnitDefinition();
      ListOf lo = m.getListOfUnitDefinitions();
      assertTrue( lo == m.getUnitDefinition(0).getParentSBMLObject() );
      assertTrue( lo == ud.getParentSBMLObject() );
      assertTrue( m == lo.getParentSBMLObject() );
      m = null;
    }

    public void test_Unit_parent_add()
    {
      UnitDefinition ud = new UnitDefinition(2,4);
      Unit u = new Unit(2,4);
      u.setKind(libsbml.UNIT_KIND_MOLE);
      ud.addUnit(u);
      u = null;
      assertTrue( ud.getNumUnits() == 1 );
      ListOf lo = ud.getListOfUnits();
      assertTrue( lo == ud.getUnit(0).getParentSBMLObject() );
      assertTrue( ud == lo.getParentSBMLObject() );
      ud = null;
    }

    public void test_Unit_parent_create()
    {
      UnitDefinition ud = new UnitDefinition(2,4);
      Unit u = ud.createUnit();
      assertTrue( ud.getNumUnits() == 1 );
      ListOf lo = ud.getListOfUnits();
      assertTrue( lo == ud.getUnit(0).getParentSBMLObject() );
      assertTrue( lo == u.getParentSBMLObject() );
      assertTrue( ud == lo.getParentSBMLObject() );
      ud = null;
    }

    public void test_Unit_parent_create_model()
    {
      Model m = new Model(2,4);
      UnitDefinition ud = m.createUnitDefinition();
      Unit u = m.createUnit();
      assertTrue( ud.getNumUnits() == 1 );
      ListOf lo = ud.getListOfUnits();
      assertTrue( lo == ud.getUnit(0).getParentSBMLObject() );
      assertTrue( lo == u.getParentSBMLObject() );
      assertTrue( ud == lo.getParentSBMLObject() );
      m = null;
    }

  }
}
