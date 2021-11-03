#
# @file    TestParameter.py
# @brief   Parameter unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Ben Bornstein 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestParameter.c
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


class TestParameter(unittest.TestCase):

  global P
  P = None

  def setUp(self):
    self.P = libsbml.Parameter(2,4)
    if (self.P == None):
      pass    
    pass  

  def tearDown(self):
    _dummyList = [ self.P ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Parameter_create(self):
    self.assertTrue( self.P.getTypeCode() == libsbml.SBML_PARAMETER )
    self.assertTrue( self.P.getMetaId() == "" )
    self.assertTrue( self.P.getNotes() == None )
    self.assertTrue( self.P.getAnnotation() == None )
    self.assertTrue( self.P.getId() == "" )
    self.assertTrue( self.P.getName() == "" )
    self.assertTrue( self.P.getUnits() == "" )
    self.assertTrue( self.P.getConstant() == True )
    self.assertEqual( False, self.P.isSetId() )
    self.assertEqual( False, self.P.isSetName() )
    self.assertEqual( False, self.P.isSetValue() )
    self.assertEqual( False, self.P.isSetUnits() )
    self.assertEqual( True, self.P.isSetConstant() )
    pass  

  def test_Parameter_createWithNS(self):
    xmlns = libsbml.XMLNamespaces()
    xmlns.add( "http://www.sbml.org", "testsbml")
    sbmlns = libsbml.SBMLNamespaces(2,1)
    sbmlns.addNamespaces(xmlns)
    object = libsbml.Parameter(sbmlns)
    self.assertTrue( object.getTypeCode() == libsbml.SBML_PARAMETER )
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

  def test_Parameter_free_NULL(self):
    _dummyList = [ None ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_Parameter_getsetConstant(self):
    self.assertTrue( self.P.getConstant() == True )
    self.assertTrue( self.P.isSetConstant() == True )
    self.P.setConstant(True)
    self.assertTrue( self.P.getConstant() == True )
    self.assertTrue( self.P.isSetConstant() == True )
    ret = self.P.unsetConstant()
    self.assertTrue( ret == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertTrue( self.P.getConstant() == True )
    self.assertTrue( self.P.isSetConstant() == True )
    self.P.setConstant(False)
    self.assertTrue( self.P.getConstant() == False )
    self.assertTrue( self.P.isSetConstant() == True )
    ret = self.P.unsetConstant()
    self.assertTrue( ret == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertTrue( self.P.getConstant() == True )
    self.assertTrue( self.P.isSetConstant() == True )
    pass  

  def test_Parameter_setId(self):
    id =  "Km1";
    self.P.setId(id)
    self.assertTrue(( id == self.P.getId() ))
    self.assertEqual( True, self.P.isSetId() )
    if (self.P.getId() == id):
      pass    
    self.P.setId(self.P.getId())
    self.assertTrue(( id == self.P.getId() ))
    self.P.setId("")
    self.assertEqual( False, self.P.isSetId() )
    if (self.P.getId() != None):
      pass    
    pass  

  def test_Parameter_setName(self):
    name =  "Forward_Michaelis_Menten_Constant";
    self.P.setName(name)
    self.assertTrue(( name == self.P.getName() ))
    self.assertEqual( True, self.P.isSetName() )
    if (self.P.getName() == name):
      pass    
    self.P.setName(self.P.getName())
    self.assertTrue(( name == self.P.getName() ))
    self.P.setName("")
    self.assertEqual( False, self.P.isSetName() )
    if (self.P.getName() != None):
      pass    
    pass  

  def test_Parameter_setUnits(self):
    units =  "second";
    self.P.setUnits(units)
    self.assertTrue(( units == self.P.getUnits() ))
    self.assertEqual( True, self.P.isSetUnits() )
    if (self.P.getUnits() == units):
      pass    
    self.P.setUnits(self.P.getUnits())
    self.assertTrue(( units == self.P.getUnits() ))
    self.P.setUnits("")
    self.assertEqual( False, self.P.isSetUnits() )
    if (self.P.getUnits() != None):
      pass    
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestParameter))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
