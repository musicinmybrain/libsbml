#
# @file    TestReadFromFile6.py
# @brief   Reads test-data/l2v2-newComponents.xml into memory and tests it.
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestReadFromFile6.cpp
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


class TestReadFromFile6(unittest.TestCase):


  def test_read_l2v2_newComponents(self):
    reader = libsbml.SBMLReader()
    filename = "../../sbml/sbml/test/test-data/"
    filename += "l2v2-newComponents.xml"
    d = reader.readSBML(filename)
    if (d == None):
      pass    
    self.assertTrue( d.getLevel() == 2 )
    self.assertTrue( d.getVersion() == 2 )
    m = d.getModel()
    self.assertTrue( m != None )
    self.assertTrue( m.getId() ==  "l2v2_newComponents" )
    self.assertTrue( m.getSBOTerm() == 4 )
    self.assertTrue( m.getSBOTermID() ==  "SBO:0000004" )
    self.assertTrue( m.getNumCompartments() == 2 )
    c = m.getCompartment(0)
    self.assertTrue( c != None )
    self.assertTrue( c.getId() ==  "cell" )
    self.assertTrue( c.getCompartmentType() ==  "mitochondria" )
    self.assertTrue( c.getOutside() ==  "m" )
    self.assertTrue( c.getSBOTerm() == -1 )
    self.assertTrue( c.getSBOTermID() ==  "" )
    c = m.getCompartment(1)
    self.assertTrue( c != None )
    self.assertTrue( c.getId() ==  "m" )
    self.assertTrue( c.getCompartmentType() ==  "mitochondria" )
    self.assertTrue( m.getNumCompartmentTypes() == 1 )
    ct = m.getCompartmentType(0)
    self.assertTrue( ct != None )
    self.assertTrue( ct.getId() ==  "mitochondria" )
    loct = m.getListOfCompartmentTypes()
    ct1 = loct.get(0)
    self.assertTrue( ct1 == ct )
    ct1 = loct.get("mitochondria")
    self.assertTrue( ct1 == ct )
    self.assertTrue( m.getNumSpeciesTypes() == 1 )
    st = m.getSpeciesType(0)
    self.assertTrue( st != None )
    self.assertTrue( st.getId() ==  "Glucose" )
    self.assertTrue( m.getNumSpecies() == 2 )
    s = m.getSpecies(0)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "X0" )
    self.assertTrue( s.getSpeciesType() ==  "Glucose" )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertEqual( False, s.isSetInitialAmount() )
    self.assertEqual( False, s.isSetInitialConcentration() )
    s = m.getSpecies(1)
    self.assertTrue( s != None )
    self.assertTrue( s.getId() ==  "X1" )
    self.assertEqual( False, s.isSetSpeciesType() )
    self.assertTrue( s.getCompartment() ==  "cell" )
    self.assertTrue( s.getInitialConcentration() == 0.013 )
    self.assertEqual( False, s.isSetInitialAmount() )
    self.assertEqual( True, s.isSetInitialConcentration() )
    self.assertTrue( m.getNumParameters() == 1 )
    p = m.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getId() ==  "y" )
    self.assertTrue( p.getValue() == 2 )
    self.assertTrue( p.getUnits() ==  "dimensionless" )
    self.assertTrue( p.getId() ==  "y" )
    self.assertTrue( p.getSBOTerm() == 2 )
    self.assertTrue( p.getSBOTermID() ==  "SBO:0000002" )
    self.assertTrue( m.getNumConstraints() == 1 )
    con = m.getConstraint(0)
    self.assertTrue( con != None )
    self.assertTrue( con.getSBOTerm() == 64 )
    self.assertTrue( con.getSBOTermID() ==  "SBO:0000064" )
    ast = con.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "lt(1, cell)" == math ))
    locon = m.getListOfConstraints()
    con1 = locon.get(0)
    self.assertTrue( con1 == con )
    self.assertTrue( m.getNumInitialAssignments() == 1 )
    ia = m.getInitialAssignment(0)
    self.assertTrue( ia != None )
    self.assertTrue( ia.getSBOTerm() == 64 )
    self.assertTrue( ia.getSBOTermID() ==  "SBO:0000064" )
    self.assertTrue( ia.getSymbol() ==  "X0" )
    ast = ia.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "y * X1" == math ))
    loia = m.getListOfInitialAssignments()
    ia1 = loia.get(0)
    self.assertTrue( ia1 == ia )
    ia1 = loia.get("X0")
    self.assertTrue( ia1 == ia )
    self.assertTrue( m.getNumReactions() == 1 )
    r = m.getReaction(0)
    self.assertTrue( r != None )
    self.assertTrue( r.getSBOTerm() == 231 )
    self.assertTrue( r.getSBOTermID() ==  "SBO:0000231" )
    self.assertTrue( r.getId() ==  "in" )
    lor = m.getListOfReactions()
    r1 = lor.get(0)
    self.assertTrue( r1 == r )
    r1 = lor.get("in")
    self.assertTrue( r1 == r )
    self.assertEqual( True, r.isSetKineticLaw() )
    kl = r.getKineticLaw()
    self.assertTrue( kl != None )
    self.assertTrue( kl.getSBOTerm() == 1 )
    self.assertTrue( kl.getSBOTermID() ==  "SBO:0000001" )
    self.assertEqual( True, kl.isSetMath() )
    ast = kl.getMath()
    math = libsbml.formulaToString(ast)
    self.assertTrue((  "v * X0 / t" == math ))
    self.assertTrue( kl.getNumParameters() == 2 )
    p = kl.getParameter(0)
    self.assertTrue( p != None )
    self.assertTrue( p.getSBOTerm() == 2 )
    self.assertTrue( p.getSBOTermID() ==  "SBO:0000002" )
    self.assertTrue( p.getId() ==  "v" )
    self.assertTrue( p.getUnits() ==  "litre" )
    self.assertTrue( r.getNumReactants() == 1 )
    self.assertTrue( r.getNumProducts() == 0 )
    self.assertTrue( r.getNumModifiers() == 0 )
    sr = r.getReactant(0)
    self.assertTrue( sr != None )
    self.assertTrue( sr.getName() ==  "sarah" )
    self.assertTrue( sr.getId() ==  "me" )
    self.assertTrue( sr.getSpecies() ==  "X0" )
    losr = r.getListOfReactants()
    sr1 = losr.get(0)
    self.assertTrue( sr1 == sr )
    sr1 = losr.get("me")
    self.assertTrue( sr1 == sr )
    d = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestReadFromFile6))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
