#
# @file    TestReadFromFile7.py
# @brief   Reads test-data/l2v3-all.xml into memory and tests it.
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestReadFromFile7.cpp
# using the conversion program dev/utilities/translateTests/translateTests.pl.
# Any changes made here will be lost the next time the file is regenerated.
#
# -----------------------------------------------------------------------------
# This file is part of libSBML.  Please visit http://sbml.org for more
# information about SBML, and the latest version of libSBML.
#
# Copyright 2005-2010 California Institute of Technology.
# Copyright 2002-2005 California Institute of Technology and
#                     Japan Science and Technology Corporation.
# 
# This library is free software; you can redistribute it and/or modify it
# under the terms of the GNU Lesser General Public License as published by
# the Free Software Foundation.  A copy of the license agreement is provided
# in the file named "LICENSE.txt" included with this software distribution
# and also available online as http://sbml.org/software/libsbml/license.html
# -----------------------------------------------------------------------------

import sys
import unittest
import libsbml


class TestReadFromFile7(unittest.TestCase):


  def test_read_l2v3_all(self):
    reader = libsbml.SBMLReader()
    filename = "../../sbml/sbml/test/test-data/"
    filename += "l2v3-all.xml"
    d = reader.readSBML(filename)
    if (d == None):
      pass    
    self.assertTrue( d.getLevel() == 2 )
    self.assertTrue( d.getVersion() == 3 )
    m = d.getModel()
    self.assertTrue( m != None )
    self.assertTrue( m.getId() ==  "l2v3_all" )
    self.assertTrue( m.getNumCompartments() == 1 )
    c = m.getCompartment(0)
    self.assertTrue( c != None )
    self.assertTrue( c.getId() ==  "a" )
    self.assertTrue( c.getCompartmentType() ==  "hh" )
    self.assertTrue( c.getSBOTerm() == 236 )
    self.assertTrue( c.getSBOTermID() ==  "SBO:0000236" )
    self.assertTrue( c.getSize() == 2.3 )
    self.assertTrue( m.getNumCompartmentTypes() == 1 )
    ct = m.getCompartmentType(0)
    self.assertTrue( ct != None )
    self.assertTrue( ct.getId() ==  "hh" )
    self.assertTrue( ct.getSBOTerm() == 236 )
    self.assertTrue( ct.getSBOTermID() ==  "SBO:0000236" )
    self.assertTrue( m.getNumSpeciesTypes() == 1 )
    st = m.getSpeciesType(0)
    self.assertTrue( st != None )
    self.assertTrue( st.getId() ==  "gg" )
    self.assertTrue( st.getName() ==  "dd" )
    self.assertTrue( st.getSBOTerm() == 236 )
    self.assertTrue( st.getSBOTermID() ==  "SBO:0000236" )
    lost = m.getListOfSpeciesTypes()
    st1 = lost.get(0)
    self.assertTrue( st1 == st )
    st1 = lost.get("gg")
    self.assertTrue( st1 == st )
    self.assertTrue( m.getNumConstraints() == 1 )
    con = m.getConstraint(0)
    self.assertTrue( con != None )
    ast = con.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "lt(x, 3)" == math ))
    self.assertTrue( m.getNumEvents() == 1 )
    e = m.getEvent(0)
    self.assertTrue( e != None )
    self.assertTrue( e.getId() ==  "e1" )
    self.assertTrue( e.getSBOTerm() == 231 )
    self.assertTrue( e.getSBOTermID() ==  "SBO:0000231" )
    self.assertEqual( True, e.isSetDelay() )
    delay = e.getDelay()
    self.assertTrue( delay != None )
    self.assertTrue( delay.getSBOTerm() == 64 )
    self.assertTrue( delay.getSBOTermID() ==  "SBO:0000064" )
    ast = delay.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "p + 3" == math ))
    self.assertEqual( True, e.isSetTrigger() )
    trigger = e.getTrigger()
    self.assertTrue( trigger != None )
    self.assertTrue( trigger.getSBOTerm() == 64 )
    self.assertTrue( trigger.getSBOTermID() ==  "SBO:0000064" )
    ast = trigger.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "lt(x, 3)" == math ))
    loe = m.getListOfEvents()
    e1 = loe.get(0)
    self.assertTrue( e1 == e )
    e1 = loe.get("e1")
    self.assertTrue( e1 == e )
    self.assertTrue( e.getNumEventAssignments() == 1 )
    ea = e.getEventAssignment(0)
    self.assertTrue( ea != None )
    self.assertTrue( ea.getVariable() ==  "a" )
    self.assertTrue( ea.getSBOTerm() == 64 )
    self.assertTrue( ea.getSBOTermID() ==  "SBO:0000064" )
    ast = ea.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "x * p3" == math ))
    loea = e.getListOfEventAssignments()
    ea1 = loea.get(0)
    self.assertTrue( ea1 == ea )
    ea1 = loea.get("a")
    self.assertTrue( ea1 == ea )
    self.assertTrue( m.getNumFunctionDefinitions() == 1 )
    fd = m.getFunctionDefinition(0)
    self.assertTrue( fd != None )
    self.assertTrue( fd.getId() ==  "fd" )
    self.assertTrue( fd.getSBOTerm() == 64 )
    self.assertTrue( fd.getSBOTermID() ==  "SBO:0000064" )
    ast = fd.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "lambda(x, pow(x, 3))" == math ))
    lofd = m.getListOfFunctionDefinitions()
    fd1 = lofd.get(0)
    self.assertTrue( fd1 == fd )
    fd1 = lofd.get("fd")
    self.assertTrue( fd1 == fd )
    self.assertTrue( m.getNumInitialAssignments() == 1 )
    ia = m.getInitialAssignment(0)
    self.assertTrue( ia != None )
    self.assertTrue( ia.getSymbol() ==  "p1" )
    ast = ia.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "x * p3" == math ))
    self.assertTrue( m.getNumRules() == 3 )
    alg = m.getRule(0)
    self.assertTrue( alg != None )
    self.assertTrue( alg.getSBOTerm() == 64 )
    self.assertTrue( alg.getSBOTermID() ==  "SBO:0000064" )
    ast = alg.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "pow(x, 3)" == math ))
    ar = m.getRule(1)
    self.assertTrue( ar != None )
    self.assertTrue( ar.getVariable() ==  "p2" )
    self.assertTrue( ar.getSBOTerm() == 64 )
    self.assertTrue( ar.getSBOTermID() ==  "SBO:0000064" )
    ast = ar.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "x * p3" == math ))
    rr = m.getRule(2)
    self.assertTrue( rr != None )
    self.assertTrue( rr.getVariable() ==  "p3" )
    self.assertTrue( rr.getSBOTerm() == 64 )
    self.assertTrue( rr.getSBOTermID() ==  "SBO:0000064" )
    ast = rr.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "p1 / p" == math ))
    self.assertTrue( m.getNumSpecies() == 1 )
    s = m.getSpecies(0)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "s" )
    self.assertTrue( s.getSpeciesType() ==  "gg" )
    self.assertTrue( s.getCompartment() ==  "a" )
    self.assertTrue( s.getSBOTerm() == 236 )
    self.assertTrue( s.getSBOTermID() ==  "SBO:0000236" )
    self.assertEqual( True, s.isSetInitialAmount() )
    self.assertEqual( False, s.isSetInitialConcentration() )
    self.assertTrue( s.getInitialAmount() == 0 )
    self.assertTrue( m.getNumReactions() == 1 )
    r = m.getReaction(0)
    self.assertTrue( r != None )
    self.assertTrue( r.getId() ==  "r" )
    self.assertEqual( False, r.getReversible() )
    self.assertEqual( True, r.getFast() )
    self.assertEqual( True, r.isSetKineticLaw() )
    kl = r.getKineticLaw()
    self.assertTrue( kl != None )
    self.assertEqual( True, kl.isSetMath() )
    ast = kl.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "s * k / p" == math ))
    self.assertTrue( kl.getNumParameters() == 2 )
    p = kl.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "k" )
    self.assertTrue( p.getUnits() ==  "litre" )
    self.assertTrue( p.getValue() == 9 )
    ud = p.getDerivedUnitDefinition()
    self.assertTrue( ud.getNumUnits() == 1 )
    self.assertTrue( ud.getUnit(0).getKind() == libsbml.UNIT_KIND_LITRE )
    self.assertTrue( ud.getUnit(0).getExponent() == 1 )
    lop = kl.getListOfParameters()
    p1 = lop.get(0)
    self.assertTrue( p1 == p )
    p1 = lop.get("k")
    self.assertTrue( p1 == p )
    p = kl.getParameter(1)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "k1" )
    self.assertTrue( p.getUnits() ==  "ud1" )
    self.assertTrue( p.getValue() == 9 )
    ud = p.getDerivedUnitDefinition()
    self.assertTrue( ud.getNumUnits() == 1 )
    self.assertTrue( ud.getUnit(0).getKind() == libsbml.UNIT_KIND_MOLE )
    self.assertTrue( ud.getUnit(0).getExponent() == 1 )
    self.assertTrue( r.getNumReactants() == 1 )
    self.assertTrue( r.getNumProducts() == 0 )
    self.assertTrue( r.getNumModifiers() == 0 )
    sr = r.getReactant(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getSpecies() ==  "s" )
    self.assertTrue( sr.getSBOTerm() == 11 )
    self.assertTrue( sr.getSBOTermID() ==  "SBO:0000011" )
    stoich = sr.getStoichiometryMath()
    self.assertTrue( stoich != None )
    self.assertTrue( stoich.getSBOTerm() == 64 )
    self.assertTrue( stoich.getSBOTermID() ==  "SBO:0000064" )
    ast = stoich.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "s * p" == math ))
    self.assertTrue( m.getNumUnitDefinitions() == 1 )
    ud = m.getUnitDefinition(0)
    self.assertTrue( ud != None )
    self.assertTrue( ud.getId() ==  "ud1" )
    loud = m.getListOfUnitDefinitions()
    ud1 = loud.get(0)
    self.assertTrue( ud1 == ud )
    ud1 = loud.get("ud1")
    self.assertTrue( ud1 == ud )
    self.assertTrue( ud.getNumUnits() == 1 )
    u = ud.getUnit(0)
    self.assertTrue( u != None )
    self.assertTrue( u.getKind() == libsbml.UNIT_KIND_MOLE )
    lou = ud.getListOfUnits()
    u1 = lou.get(0)
    self.assertTrue( u1 == u )
    d = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestReadFromFile7))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
