#
# @file    TestReadFromFile5.py
# @brief   Reads test-data/l2v1-assignment.xml into memory and tests it.
#
# @author  Akiya Jouraku (Python conversion)
# @author  Ben Bornstein 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestReadFromFile5.cpp
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


class TestReadFromFile5(unittest.TestCase):


  def test_read_l2v1_assignment(self):
    reader = libsbml.SBMLReader()
    filename = "../../sbml/sbml/test/test-data/"
    filename += "l2v1-assignment.xml"
    d = reader.readSBML(filename)
    if (d == None):
      pass    
    self.assertTrue( d.getLevel() == 2 )
    self.assertTrue( d.getVersion() == 1 )
    m = d.getModel()
    self.assertTrue( m != None )
    self.assertTrue( m.getNumCompartments() == 1 )
    c = m.getCompartment(0)
    self.assertTrue( c != None )
    self.assertTrue( c.getId() ==  "cell" )
    ud = c.getDerivedUnitDefinition()
    self.assertTrue( ud.getNumUnits() == 1 )
    self.assertTrue( ud.getUnit(0).getKind() == libsbml.UNIT_KIND_LITRE )
    loc = m.getListOfCompartments()
    c1 = loc.get(0)
    self.assertTrue( c1 == c )
    c1 = loc.get("cell")
    self.assertTrue( c1 == c )
    self.assertTrue( m.getNumSpecies() == 5 )
    s = m.getSpecies(0)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "X0"   )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 1.0 )
    los = m.getListOfSpecies()
    s1 = los.get(0)
    self.assertTrue( s1 == s )
    s1 = los.get("X0")
    self.assertTrue( s1 == s )
    s = m.getSpecies(1)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "X1"   )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 0.0 )
    s = m.getSpecies(2)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "T"    )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 0.0 )
    s = m.getSpecies(3)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "S1"   )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 0.0 )
    s = m.getSpecies(4)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "S2"   )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 0.0 )
    self.assertTrue( m.getNumParameters() == 1 )
    p = m.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "Keq" )
    self.assertTrue( p.getValue() == 2.5 )
    lop = m.getListOfParameters()
    p1 = lop.get(0)
    self.assertTrue( p1 == p )
    p1 = lop.get("Keq")
    self.assertTrue( p1 == p )
    ud = p.getDerivedUnitDefinition()
    self.assertTrue( ud.getNumUnits() == 0 )
    self.assertTrue( m.getNumRules() == 2 )
    ar = m.getRule(0)
    self.assertTrue( ar != None )
    self.assertTrue( ar.getVariable() ==  "S1"            )
    self.assertTrue( ar.getFormula() ==  "T / (1 + Keq)" )
    ud = ar.getDerivedUnitDefinition()
    self.assertTrue( ud.getNumUnits() == 2 )
    self.assertTrue( ud.getUnit(0).getKind() == libsbml.UNIT_KIND_MOLE )
    self.assertTrue( ud.getUnit(0).getExponent() == 1 )
    self.assertTrue( ud.getUnit(1).getKind() == libsbml.UNIT_KIND_LITRE )
    self.assertTrue( ud.getUnit(1).getExponent() == -1 )
    self.assertTrue( ar.containsUndeclaredUnits() == True )
    lor = m.getListOfRules()
    ar1 = lor.get(0)
    self.assertTrue( ar1 == ar )
    ar1 = lor.get("S1")
    self.assertTrue( ar1 == ar )
    ar = m.getRule(1)
    self.assertTrue( ar != None )
    self.assertTrue( ar.getVariable() ==  "S2"       )
    self.assertTrue( ar.getFormula() ==  "Keq * S1" )
    self.assertTrue( m.getNumReactions() == 2 )
    r = m.getReaction(0)
    self.assertTrue( r != None )
    self.assertTrue( r.getId() ==  "in" )
    self.assertTrue( r.getNumReactants() == 1 )
    self.assertTrue( r.getNumProducts() == 1 )
    sr = r.getReactant(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getSpecies() ==  "X0" )
    sr = r.getProduct(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getSpecies() ==  "T"  )
    kl = r.getKineticLaw()
    self.assertTrue( kl != None )
    self.assertTrue( kl.getFormula() ==  "k1 * X0" )
    self.assertTrue( kl.getNumParameters() == 1 )
    r1 = kl.getParentSBMLObject()
    self.assertTrue( r1 != None )
    self.assertTrue( r1.getId() ==  "in" )
    self.assertTrue( r1.getNumReactants() == 1 )
    self.assertTrue( r1.getNumProducts() == 1 )
    p = kl.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "k1" )
    self.assertTrue( p.getValue() == 0.1 )
    kl = p.getParentSBMLObject().getParentSBMLObject()
    self.assertTrue( kl != None )
    self.assertTrue( kl.getFormula() ==  "k1 * X0" )
    self.assertTrue( kl.getNumParameters() == 1 )
    r = m.getReaction(1)
    self.assertTrue( r != None )
    self.assertTrue( r.getId() ==  "out" )
    self.assertTrue( r.getNumReactants() == 1 )
    self.assertTrue( r.getNumProducts() == 1 )
    sr = r.getReactant(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getSpecies() ==  "T"  )
    sr = r.getProduct(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getSpecies() ==  "X1" )
    kl = r.getKineticLaw()
    self.assertTrue( kl != None )
    self.assertTrue( kl.getFormula() ==  "k2 * T" )
    self.assertTrue( kl.getNumParameters() == 1 )
    p = kl.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "k2" )
    self.assertTrue( p.getValue() == 0.15 )
    d = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestReadFromFile5))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
