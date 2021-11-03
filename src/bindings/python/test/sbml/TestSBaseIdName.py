#
# @file    TestSBaseIdName.py
# @brief   SBase unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Ben Bornstein 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestSBaseIdName.cpp
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


class TestSBaseIdName(unittest.TestCase):

  global S31
  S31 = None
  global S32
  S32 = None
  global EA31
  EA31 = None
  global EA32
  EA32 = None
  global E32
  E32 = None
  global U31
  U31 = None
  global E31
  E31 = None
  global AR31
  AR31 = None
  global AR32
  AR32 = None
  global U32
  U32 = None

  def setUp(self):
    self.S31 = libsbml.Species(3,1)
    if (self.S31 == None):
      pass    
    self.S32 = libsbml.Species(3,2)
    if (self.S32 == None):
      pass    
    self.E31 = libsbml.Event(3,1)
    if (self.E31 == None):
      pass    
    self.E32 = libsbml.Event(3,2)
    if (self.E32 == None):
      pass    
    self.U31 = libsbml.Unit(3,1)
    if (self.U31 == None):
      pass    
    self.U32 = libsbml.Unit(3,2)
    if (self.U32 == None):
      pass    
    self.AR31 = libsbml.AssignmentRule(3,1)
    if (self.AR31 == None):
      pass    
    self.AR32 = libsbml.AssignmentRule(3,2)
    if (self.AR32 == None):
      pass    
    self.EA31 = libsbml.EventAssignment(3,1)
    if (self.EA31 == None):
      pass    
    self.EA32 = libsbml.EventAssignment(3,2)
    if (self.EA32 == None):
      pass    
    pass  

  def tearDown(self):
    self.S31 = None
    self.S32 = None
    self.E31 = None
    self.E32 = None
    self.U31 = None
    self.U32 = None
    self.AR31 = None
    self.AR32 = None
    self.EA31 = None
    self.EA32 = None
    pass  

  def test_SBase_setIdAttribute_1(self):
    id =  "x12345";
    i = self.S31.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.S31.isSetId() )
    self.assertTrue( self.S31.getId() == id )
    self.assertEqual( True, self.S31.isSetIdAttribute() )
    self.assertTrue( self.S31.getIdAttribute() == id )
    i = self.S31.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.S31.isSetId() )
    self.assertTrue( self.S31.getId() ==  "" )
    self.assertEqual( False, self.S31.isSetIdAttribute() )
    self.assertTrue( self.S31.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_10(self):
    id =  "x12345";
    i = self.EA32.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA32.isSetId() )
    self.assertTrue( self.EA32.getId() ==  "" )
    self.assertEqual( True, self.EA32.isSetIdAttribute() )
    self.assertTrue( self.EA32.getIdAttribute() == id )
    self.assertEqual( False, self.EA32.isSetVariable() )
    self.assertTrue( self.EA32.getVariable() ==  "" )
    i = self.EA32.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA32.isSetId() )
    self.assertTrue( self.EA32.getId() ==  "" )
    self.assertEqual( False, self.EA32.isSetIdAttribute() )
    self.assertTrue( self.EA32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA32.isSetVariable() )
    self.assertTrue( self.EA32.getVariable() ==  "" )
    pass  

  def test_SBase_setIdAttribute_2(self):
    id =  "x12345";
    i = self.S32.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.S32.isSetId() )
    self.assertTrue( self.S32.getId() == id )
    self.assertEqual( True, self.S32.isSetIdAttribute() )
    self.assertTrue( self.S32.getIdAttribute() == id )
    i = self.S32.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.S32.isSetId() )
    self.assertTrue( self.S32.getId() ==  "" )
    self.assertEqual( False, self.S32.isSetIdAttribute() )
    self.assertTrue( self.S32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_3(self):
    id =  "x12345";
    i = self.E31.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.E31.isSetId() )
    self.assertTrue( self.E31.getId() == id )
    self.assertEqual( True, self.E31.isSetIdAttribute() )
    self.assertTrue( self.E31.getIdAttribute() == id )
    i = self.E31.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.E31.isSetId() )
    self.assertTrue( self.E31.getId() ==  "" )
    self.assertEqual( False, self.E31.isSetIdAttribute() )
    self.assertTrue( self.E31.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_4(self):
    id =  "x12345";
    i = self.E32.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.E32.isSetId() )
    self.assertTrue( self.E32.getId() == id )
    self.assertEqual( True, self.E32.isSetIdAttribute() )
    self.assertTrue( self.E32.getIdAttribute() == id )
    i = self.E32.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.E32.isSetId() )
    self.assertTrue( self.E32.getId() ==  "" )
    self.assertEqual( False, self.E32.isSetIdAttribute() )
    self.assertTrue( self.E32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_5(self):
    id =  "x12345";
    i = self.U31.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.U31.isSetId() )
    self.assertTrue( self.U31.getId() ==  "" )
    self.assertEqual( True, self.U31.isSetIdAttribute() )
    self.assertTrue( self.U31.getIdAttribute() == id )
    i = self.U31.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.U31.isSetId() )
    self.assertTrue( self.U31.getId() ==  "" )
    self.assertEqual( False, self.U31.isSetIdAttribute() )
    self.assertTrue( self.U31.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_6(self):
    id =  "x12345";
    i = self.U32.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.U32.isSetId() )
    self.assertTrue( self.U32.getId() == id )
    self.assertEqual( True, self.U32.isSetIdAttribute() )
    self.assertTrue( self.U32.getIdAttribute() == id )
    i = self.U32.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.U32.isSetId() )
    self.assertTrue( self.U32.getId() ==  "" )
    self.assertEqual( False, self.U32.isSetIdAttribute() )
    self.assertTrue( self.U32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setIdAttribute_7(self):
    id =  "x12345";
    i = self.AR31.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( True, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() == id )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    i = self.AR31.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    pass  

  def test_SBase_setIdAttribute_8(self):
    id =  "x12345";
    i = self.AR32.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR32.isSetId() )
    self.assertTrue( self.AR32.getId() ==  "" )
    self.assertEqual( True, self.AR32.isSetIdAttribute() )
    self.assertTrue( self.AR32.getIdAttribute() == id )
    self.assertEqual( False, self.AR32.isSetVariable() )
    self.assertTrue( self.AR32.getVariable() ==  "" )
    i = self.AR32.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR32.isSetId() )
    self.assertTrue( self.AR32.getId() ==  "" )
    self.assertEqual( False, self.AR32.isSetIdAttribute() )
    self.assertTrue( self.AR32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR32.isSetVariable() )
    self.assertTrue( self.AR32.getVariable() ==  "" )
    pass  

  def test_SBase_setIdAttribute_9(self):
    id =  "x12345";
    i = self.EA31.setIdAttribute(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( True, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() == id )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    i = self.EA31.unsetIdAttribute()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    pass  

  def test_SBase_setId_1(self):
    id =  "x12345";
    i = self.S31.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.S31.isSetId() )
    self.assertTrue( self.S31.getId() == id )
    self.assertEqual( True, self.S31.isSetIdAttribute() )
    self.assertTrue( self.S31.getIdAttribute() == id )
    i = self.S31.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED )
    self.assertEqual( True, self.S31.isSetId() )
    self.assertTrue( self.S31.getId() == id )
    self.assertEqual( True, self.S31.isSetIdAttribute() )
    self.assertTrue( self.S31.getIdAttribute() == id )
    pass  

  def test_SBase_setId_10(self):
    id =  "x12345";
    i = self.EA32.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_USE_ID_ATTRIBUTE_FUNCTION )
    self.assertEqual( False, self.EA32.isSetId() )
    self.assertTrue( self.EA32.getId() ==  "" )
    self.assertEqual( False, self.EA32.isSetIdAttribute() )
    self.assertTrue( self.EA32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA32.isSetVariable() )
    self.assertTrue( self.EA32.getVariable() ==  "" )
    i = self.EA32.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_USE_ID_ATTRIBUTE_FUNCTION )
    self.assertEqual( False, self.EA32.isSetId() )
    self.assertTrue( self.EA32.getId() ==  "" )
    self.assertEqual( False, self.EA32.isSetIdAttribute() )
    self.assertTrue( self.EA32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA32.isSetVariable() )
    self.assertTrue( self.EA32.getVariable() ==  "" )
    pass  

  def test_SBase_setId_2(self):
    id =  "x12345";
    i = self.S32.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.S32.isSetId() )
    self.assertTrue( self.S32.getId() == id )
    self.assertEqual( True, self.S32.isSetIdAttribute() )
    self.assertTrue( self.S32.getIdAttribute() == id )
    i = self.S32.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.S32.isSetId() )
    self.assertTrue( self.S32.getId() ==  "" )
    self.assertEqual( False, self.S32.isSetIdAttribute() )
    self.assertTrue( self.S32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setId_3(self):
    id =  "x12345";
    i = self.E31.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.E31.isSetId() )
    self.assertTrue( self.E31.getId() == id )
    self.assertEqual( True, self.E31.isSetIdAttribute() )
    self.assertTrue( self.E31.getIdAttribute() == id )
    i = self.E31.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.E31.isSetId() )
    self.assertTrue( self.E31.getId() ==  "" )
    self.assertEqual( False, self.E31.isSetIdAttribute() )
    self.assertTrue( self.E31.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setId_4(self):
    id =  "x12345";
    i = self.E32.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.E32.isSetId() )
    self.assertTrue( self.E32.getId() == id )
    self.assertEqual( True, self.E32.isSetIdAttribute() )
    self.assertTrue( self.E32.getIdAttribute() == id )
    i = self.E32.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.E32.isSetId() )
    self.assertTrue( self.E32.getId() ==  "" )
    self.assertEqual( False, self.E32.isSetIdAttribute() )
    self.assertTrue( self.E32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setId_5(self):
    id =  "x12345";
    i = self.U31.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.U31.isSetId() )
    self.assertTrue( self.U31.getId() ==  "" )
    self.assertEqual( False, self.U31.isSetIdAttribute() )
    self.assertTrue( self.U31.getIdAttribute() ==  "" )
    i = self.U31.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED )
    self.assertEqual( False, self.U31.isSetId() )
    self.assertTrue( self.U31.getId() ==  "" )
    self.assertEqual( False, self.U31.isSetIdAttribute() )
    self.assertTrue( self.U31.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setId_6(self):
    id =  "x12345";
    i = self.U32.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.U32.isSetId() )
    self.assertTrue( self.U32.getId() == id )
    self.assertEqual( True, self.U32.isSetIdAttribute() )
    self.assertTrue( self.U32.getIdAttribute() == id )
    i = self.U32.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.U32.isSetId() )
    self.assertTrue( self.U32.getId() ==  "" )
    self.assertEqual( False, self.U32.isSetIdAttribute() )
    self.assertTrue( self.U32.getIdAttribute() ==  "" )
    pass  

  def test_SBase_setId_7(self):
    id =  "x12345";
    i = self.AR31.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    i = self.AR31.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    pass  

  def test_SBase_setId_8(self):
    id =  "x12345";
    i = self.AR32.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_USE_ID_ATTRIBUTE_FUNCTION )
    self.assertEqual( False, self.AR32.isSetId() )
    self.assertTrue( self.AR32.getId() ==  "" )
    self.assertEqual( False, self.AR32.isSetIdAttribute() )
    self.assertTrue( self.AR32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR32.isSetVariable() )
    self.assertTrue( self.AR32.getVariable() ==  "" )
    i = self.AR32.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_USE_ID_ATTRIBUTE_FUNCTION )
    self.assertEqual( False, self.AR32.isSetId() )
    self.assertTrue( self.AR32.getId() ==  "" )
    self.assertEqual( False, self.AR32.isSetIdAttribute() )
    self.assertTrue( self.AR32.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR32.isSetVariable() )
    self.assertTrue( self.AR32.getVariable() ==  "" )
    pass  

  def test_SBase_setId_9(self):
    id =  "x12345";
    i = self.EA31.setId(id)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    i = self.EA31.unsetId()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    pass  

  def test_SBase_setName_1(self):
    name =  "x12345";
    self.S31.setName(name)
    self.assertTrue(( name == self.S31.getName() ))
    self.assertEqual( True, self.S31.isSetName() )
    if (self.S31.getName() == name):
      pass    
    self.S31.setName(self.S31.getName())
    self.assertTrue(( name == self.S31.getName() ))
    self.S31.setName("")
    self.assertEqual( False, self.S31.isSetName() )
    if (self.S31.getName() != None):
      pass    
    pass  

  def test_SBase_setName_10(self):
    name =  "x12345";
    self.EA32.setName(name)
    self.assertTrue(( name == self.EA32.getName() ))
    self.assertEqual( True, self.EA32.isSetName() )
    if (self.EA32.getName() == name):
      pass    
    self.EA32.setName(self.EA32.getName())
    self.assertTrue(( name == self.EA32.getName() ))
    self.EA32.setName("")
    self.assertEqual( False, self.EA32.isSetName() )
    if (self.EA32.getName() != None):
      pass    
    pass  

  def test_SBase_setName_2(self):
    name =  "x12345";
    self.S32.setName(name)
    self.assertTrue(( name == self.S32.getName() ))
    self.assertEqual( True, self.S32.isSetName() )
    if (self.S32.getName() == name):
      pass    
    self.S32.setName(self.S32.getName())
    self.assertTrue(( name == self.S32.getName() ))
    self.S32.setName("")
    self.assertEqual( False, self.S32.isSetName() )
    if (self.S32.getName() != None):
      pass    
    pass  

  def test_SBase_setName_3(self):
    name =  "x12345";
    self.E31.setName(name)
    self.assertTrue(( name == self.E31.getName() ))
    self.assertEqual( True, self.E31.isSetName() )
    if (self.E31.getName() == name):
      pass    
    self.E31.setName(self.E31.getName())
    self.assertTrue(( name == self.E31.getName() ))
    self.E31.setName("")
    self.assertEqual( False, self.E31.isSetName() )
    if (self.E31.getName() != None):
      pass    
    pass  

  def test_SBase_setName_4(self):
    name =  "x12345";
    self.E32.setName(name)
    self.assertTrue(( name == self.E32.getName() ))
    self.assertEqual( True, self.E32.isSetName() )
    if (self.E32.getName() == name):
      pass    
    self.E32.setName(self.E32.getName())
    self.assertTrue(( name == self.E32.getName() ))
    self.E32.setName("")
    self.assertEqual( False, self.E32.isSetName() )
    if (self.E32.getName() != None):
      pass    
    pass  

  def test_SBase_setName_5(self):
    name =  "x12345";
    i = self.U31.setName(name)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.U31.isSetName() )
    self.assertTrue( self.U31.getName() == "" )
    pass  

  def test_SBase_setName_6(self):
    name =  "x12345";
    self.U32.setName(name)
    self.assertTrue(( name == self.U32.getName() ))
    self.assertEqual( True, self.U32.isSetName() )
    if (self.U32.getName() == name):
      pass    
    self.U32.setName(self.U32.getName())
    self.assertTrue(( name == self.U32.getName() ))
    self.U32.setName("")
    self.assertEqual( False, self.U32.isSetName() )
    if (self.U32.getName() != None):
      pass    
    pass  

  def test_SBase_setName_7(self):
    name =  "x12345";
    i = self.AR31.setName(name)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.AR31.isSetName() )
    self.assertTrue( self.AR31.getName() == "" )
    pass  

  def test_SBase_setName_8(self):
    name =  "x12345";
    self.AR32.setName(name)
    self.assertTrue(( name == self.AR32.getName() ))
    self.assertEqual( True, self.AR32.isSetName() )
    if (self.AR32.getName() == name):
      pass    
    self.AR32.setName(self.AR32.getName())
    self.assertTrue(( name == self.AR32.getName() ))
    self.AR32.setName("")
    self.assertEqual( False, self.AR32.isSetName() )
    if (self.AR32.getName() != None):
      pass    
    pass  

  def test_SBase_setName_9(self):
    name =  "x12345";
    i = self.EA31.setName(name)
    self.assertTrue( i == libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE )
    self.assertEqual( False, self.EA31.isSetName() )
    self.assertTrue( self.EA31.getName() == "" )
    pass  

  def test_SBase_setVariable_10(self):
    id =  "x12345";
    i = self.EA31.setVariable(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() == id )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( True, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() == id )
    i = self.EA31.unsetVariable()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    pass  

  def test_SBase_setVariable_7(self):
    id =  "x12345";
    i = self.AR31.setVariable(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() == id )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( True, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() == id )
    i = self.AR31.unsetVariable()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    pass  

  def test_SBase_setVariable_8(self):
    id =  "x12345";
    i = self.AR31.setVariable(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() == id )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( True, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() == id )
    i = self.AR31.unsetVariable()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.AR31.isSetId() )
    self.assertTrue( self.AR31.getId() ==  "" )
    self.assertEqual( False, self.AR31.isSetIdAttribute() )
    self.assertTrue( self.AR31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.AR31.isSetVariable() )
    self.assertTrue( self.AR31.getVariable() ==  "" )
    pass  

  def test_SBase_setVariable_9(self):
    id =  "x12345";
    i = self.EA31.setVariable(id)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( True, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() == id )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( True, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() == id )
    i = self.EA31.unsetVariable()
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertEqual( False, self.EA31.isSetId() )
    self.assertTrue( self.EA31.getId() ==  "" )
    self.assertEqual( False, self.EA31.isSetIdAttribute() )
    self.assertTrue( self.EA31.getIdAttribute() ==  "" )
    self.assertEqual( False, self.EA31.isSetVariable() )
    self.assertTrue( self.EA31.getVariable() ==  "" )
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestSBaseIdName))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
