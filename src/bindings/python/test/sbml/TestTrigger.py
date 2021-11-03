#
# @file    TestTrigger.py
# @brief   SBML Trigger unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestTrigger.c
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


class TestTrigger(unittest.TestCase):

  global D
  D = None

  def setUp(self):
    self.D = libsbml.Trigger(2,4)
    if (self.D == None):
      pass    
    pass  

  def tearDown(self):
    _dummyList = [ self.D ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Trigger_create(self):
    self.assertTrue( self.D.getTypeCode() == libsbml.SBML_TRIGGER )
    self.assertTrue( self.D.getMetaId() == "" )
    self.assertTrue( self.D.getNotes() == None )
    self.assertTrue( self.D.getAnnotation() == None )
    self.assertTrue( self.D.getMath() == None )
    pass  

  def test_Trigger_createWithNS(self):
    xmlns = libsbml.XMLNamespaces()
    xmlns.add( "http://www.sbml.org", "testsbml")
    sbmlns = libsbml.SBMLNamespaces(2,1)
    sbmlns.addNamespaces(xmlns)
    object = libsbml.Trigger(sbmlns)
    self.assertTrue( object.getTypeCode() == libsbml.SBML_TRIGGER )
    self.assertTrue( object.getMetaId() == "" )
    self.assertTrue( object.getNotes() == None )
    self.assertTrue( object.getAnnotation() == None )
    self.assertTrue( object.getLevel() == 2 )
    self.assertTrue( object.getVersion() == 1 )
    self.assertTrue( object.getNamespaces() != None )
    self.assertTrue( object.getNamespaces().getLength() == 2 )
    _dummyList = [ object ]; _dummyList[:] = []; del _dummyList
    _dummyList = [ xmlns ]; _dummyList[:] = []; del _dummyList
    _dummyList = [ sbmlns ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Trigger_free_NULL(self):
    _dummyList = [ None ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Trigger_setMath(self):
    math = libsbml.parseFormula("lambda(x, x^3)")
    self.D.setMath(math)
    math1 = self.D.getMath()
    self.assertTrue( math1 != None )
    formula = libsbml.formulaToString(math1)
    self.assertTrue( formula != None )
    self.assertTrue((  "lambda(x, x^3)" == formula ))
    self.assertTrue( self.D.getMath() != math )
    self.assertEqual( True, self.D.isSetMath() )
    self.D.setMath(self.D.getMath())
    math1 = self.D.getMath()
    self.assertTrue( math1 != None )
    formula = libsbml.formulaToString(math1)
    self.assertTrue( formula != None )
    self.assertTrue((  "lambda(x, x^3)" == formula ))
    self.D.setMath(None)
    self.assertEqual( False, self.D.isSetMath() )
    if (self.D.getMath() != None):
      pass    
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Trigger_setMath1(self):
    math = libsbml.parseFormula("2 * k")
    i = self.D.setMath(math)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( self.D.getMath() != math )
    self.assertEqual( True, self.D.isSetMath() )
    i = self.D.setMath(None)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( self.D.getMath() == None )
    self.assertEqual( False, self.D.isSetMath() )
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Trigger_setMath2(self):
    math = libsbml.ASTNode(libsbml.AST_DIVIDE)
    i = self.D.setMath(math)
    self.assertTrue( i == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertEqual( False, self.D.isSetMath() )
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestTrigger))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
