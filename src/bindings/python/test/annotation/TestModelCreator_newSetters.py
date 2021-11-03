#
# @file    TestModelCreator_newSetters.py
# @brief   ModelCreator unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestModelCreator_newSetters.c
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


class TestModelCreator_newSetters(unittest.TestCase):


  def test_ModelCreator_accessWithNULL(self):
    self.assertTrue( None.clone() == None )
    self.assertTrue( libsbml.ModelCreator(None) == None )
    _dummyList = [ None ]; _dummyList[:] = []; del _dummyList
    self.assertTrue( None.getEmail() == None )
    self.assertTrue( None.getFamilyName() == None )
    self.assertTrue( None.getGivenName() == None )
    self.assertTrue( None.getOrganisation() == None )
    self.assertTrue( None.getOrganization() == None )
    self.assertTrue( None.hasRequiredAttributes() == 0 )
    self.assertTrue( None.isSetEmail() == False )
    self.assertTrue( None.isSetFamilyName() == False )
    self.assertTrue( None.isSetGivenName() == False )
    self.assertTrue( None.isSetOrganisation() == False )
    self.assertTrue( None.isSetOrganization() == False )
    self.assertTrue( None.setEmail(None) == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.setFamilyName(None) == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.setGivenName(None) == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.setOrganisation(None) == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.setOrganization(None) == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.unsetEmail() == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.unsetFamilyName() == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.unsetGivenName() == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.unsetOrganisation() == libsbml.LIBSBML_INVALID_OBJECT )
    self.assertTrue( None.unsetOrganization() == libsbml.LIBSBML_INVALID_OBJECT )
    pass  

  def test_ModelCreator_setEmail(self):
    mc = libsbml.ModelCreator()
    self.assertTrue( mc != None )
    i = mc.setEmail( "Keating")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetEmail() == True )
    self.assertTrue((  "Keating" == mc.getEmail() ))
    i = mc.setEmail( "")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetEmail() == False )
    i = mc.setEmail( "Keating")
    self.assertTrue( mc.isSetEmail() == True )
    i = mc.unsetEmail()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetEmail() == False )
    _dummyList = [ mc ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ModelCreator_setFamilyName(self):
    mc = libsbml.ModelCreator()
    self.assertTrue( mc != None )
    i = mc.setFamilyName( "Keating")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetFamilyName() == True )
    self.assertTrue((  "Keating" == mc.getFamilyName() ))
    i = mc.setFamilyName( "")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetFamilyName() == False )
    i = mc.setFamilyName( "Keating")
    self.assertTrue( mc.isSetFamilyName() == True )
    i = mc.unsetFamilyName()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetFamilyName() == False )
    _dummyList = [ mc ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ModelCreator_setGivenName(self):
    mc = libsbml.ModelCreator()
    self.assertTrue( mc != None )
    i = mc.setGivenName( "Sarah")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetGivenName() == True )
    self.assertTrue((  "Sarah" == mc.getGivenName() ))
    i = mc.setGivenName( "")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetGivenName() == False )
    i = mc.setGivenName( "Sarah")
    self.assertTrue( mc.isSetGivenName() == True )
    i = mc.unsetGivenName()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetGivenName() == False )
    _dummyList = [ mc ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ModelCreator_setOrganization(self):
    mc = libsbml.ModelCreator()
    self.assertTrue( mc != None )
    i = mc.setOrganization( "Caltech")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetOrganization() == True )
    self.assertTrue((  "Caltech" == mc.getOrganization() ))
    i = mc.setOrganization( "")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetOrganization() == False )
    i = mc.setOrganization( "Caltech")
    self.assertTrue( mc.isSetOrganization() == True )
    i = mc.unsetOrganization()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( mc.isSetOrganization() == False )
    _dummyList = [ mc ]; _dummyList[:] = []; del _dummyList
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestModelCreator_newSetters))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
