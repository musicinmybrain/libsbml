#
# @file    TestCVTerms_newSetters.py
# @brief   CVTerms unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestCVTerms_newSetters.c
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


class TestCVTerms_newSetters(unittest.TestCase):


  def test_CVTerm_addResource(self):
    term = libsbml.CVTerm(libsbml.MODEL_QUALIFIER)
    resource =  "GO6666";
    self.assertTrue( term != None )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    i = term.addResource( "")
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_FAILED )
    xa = term.getResources()
    self.assertTrue( xa.getLength() == 0 )
    i = term.addResource(resource)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    xa = term.getResources()
    self.assertTrue( xa.getLength() == 1 )
    name = xa.getName(0)
    value = xa.getValue(0)
    self.assertTrue((  "rdf:resource" == name ))
    self.assertTrue((  "GO6666" == value ))
    name = None
    value = None
    _dummyList = [ term ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_CVTerm_removeResource(self):
    term = libsbml.CVTerm(libsbml.MODEL_QUALIFIER)
    resource =  "GO6666";
    self.assertTrue( term != None )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    term.addResource(resource)
    xa = term.getResources()
    self.assertTrue( xa.getLength() == 1 )
    i = term.removeResource( "CCC")
    self.assertTrue( i == libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE )
    xa = term.getResources()
    self.assertTrue( xa.getLength() == 1 )
    i = term.removeResource(resource)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    xa = term.getResources()
    self.assertTrue( xa.getLength() == 0 )
    _dummyList = [ term ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_CVTerm_setBiolQualifierType(self):
    term = libsbml.CVTerm(libsbml.BIOLOGICAL_QUALIFIER)
    self.assertTrue( term != None )
    self.assertTrue( term.getQualifierType() == libsbml.BIOLOGICAL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    i = term.setBiologicalQualifierType(libsbml.BQB_IS)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( term.getQualifierType() == libsbml.BIOLOGICAL_QUALIFIER )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_IS )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    i = term.setQualifierType(libsbml.MODEL_QUALIFIER)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    i = term.setBiologicalQualifierType(libsbml.BQB_IS)
    self.assertTrue( i == libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    _dummyList = [ term ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_CVTerm_setModelQualifierType(self):
    term = libsbml.CVTerm(libsbml.MODEL_QUALIFIER)
    self.assertTrue( term != None )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    i = term.setModelQualifierType(libsbml.BQM_IS)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( term.getQualifierType() == libsbml.MODEL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_IS )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    i = term.setQualifierType(libsbml.BIOLOGICAL_QUALIFIER)
    self.assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS )
    self.assertTrue( term.getQualifierType() == libsbml.BIOLOGICAL_QUALIFIER )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    i = term.setModelQualifierType(libsbml.BQM_IS)
    self.assertTrue( i == libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE )
    self.assertTrue( term.getQualifierType() == libsbml.BIOLOGICAL_QUALIFIER )
    self.assertTrue( term.getBiologicalQualifierType() == libsbml.BQB_UNKNOWN )
    self.assertTrue( term.getModelQualifierType() == libsbml.BQM_UNKNOWN )
    _dummyList = [ term ]; _dummyList[:] = []; del _dummyList
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestCVTerms_newSetters))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
