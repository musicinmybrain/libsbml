#
# @file    TestValidation.py
# @brief   Validation of Date ModelCreator and ModelHistory unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestValidation.cpp
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


class TestValidation(unittest.TestCase):


  def test_Validation_CVTerm1(self):
    cv = libsbml.CVTerm()
    self.assertTrue( cv != None )
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.setQualifierType(libsbml.MODEL_QUALIFIER)
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.setModelQualifierType(libsbml.BQM_IS)
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.addResource("ggg")
    self.assertEqual( True, (cv.hasRequiredAttributes()) )
    cv = None
    pass  

  def test_Validation_CVTerm2(self):
    cv = libsbml.CVTerm()
    self.assertTrue( cv != None )
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.setQualifierType(libsbml.BIOLOGICAL_QUALIFIER)
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.setBiologicalQualifierType(libsbml.BQB_IS)
    self.assertEqual( False, (cv.hasRequiredAttributes()) )
    cv.addResource("ggg")
    self.assertEqual( True, (cv.hasRequiredAttributes()) )
    cv = None
    pass  

  def test_Validation_Date1(self):
    date = libsbml.Date(200,12,30,12,15,45,1,2,0)
    self.assertTrue( date != None )
    self.assertEqual( False, (date.representsValidDate()) )
    date = None
    pass  

  def test_Validation_Date2(self):
    date = libsbml.Date(2007,14,30,12,15,45,1,2,0)
    self.assertTrue( date != None )
    self.assertEqual( False, (date.representsValidDate()) )
    date = None
    pass  

  def test_Validation_Date3(self):
    date = libsbml.Date("Jan 12")
    self.assertTrue( date != None )
    self.assertEqual( False, (date.representsValidDate()) )
    date = None
    pass  

  def test_Validation_Date4(self):
    date = libsbml.Date(2007,12,30,12,15,45,1,2,0)
    self.assertTrue( date != None )
    self.assertEqual( True, date.representsValidDate() )
    date = None
    pass  

  def test_Validation_Date_Default(self):
    date1 = libsbml.Date()
    date2 = libsbml.Date("")
    self.assertTrue( date1.getYear() == date2.getYear() )
    self.assertTrue( date1.getMonth() == date2.getMonth() )
    self.assertTrue( date1.getDay() == date2.getDay() )
    self.assertTrue( date1.getHour() == date2.getHour() )
    self.assertTrue( date1.getMinute() == date2.getMinute() )
    self.assertTrue( date1.getSecond() == date2.getSecond() )
    self.assertTrue( date1.getSignOffset() == date2.getSignOffset() )
    self.assertTrue( date1.getHoursOffset() == date2.getHoursOffset() )
    self.assertTrue( date1.getMinutesOffset() == date2.getMinutesOffset() )
    date1 = None
    date2 = None
    pass  

  def test_Validation_ModelCreator(self):
    mc = libsbml.ModelCreator()
    self.assertTrue( mc != None )
    self.assertEqual( False, (mc.hasRequiredAttributes()) )
    mc.setEmail("k123")
    self.assertEqual( False, (mc.hasRequiredAttributes()) )
    mc.setFamilyName("Keating")
    self.assertEqual( False, (mc.hasRequiredAttributes()) )
    mc.setGivenName("Sarah")
    self.assertEqual( True, mc.hasRequiredAttributes() )
    mc = None
    pass  

  def test_Validation_ModelHistory1(self):
    mh = libsbml.ModelHistory()
    self.assertTrue( mh != None )
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    date = libsbml.Date(2007,12,30,12,15,45,1,2,0)
    mh.setCreatedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mh.setModifiedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mc = libsbml.ModelCreator()
    mc.setFamilyName("Keating")
    mc.setGivenName("Sarah")
    mh.addCreator(mc)
    self.assertEqual( True, mh.hasRequiredAttributes() )
    mh = None
    mc = None
    date = None
    pass  

  def test_Validation_ModelHistory2(self):
    mh = libsbml.ModelHistory()
    self.assertTrue( mh != None )
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    date = libsbml.Date(200,12,30,12,15,45,1,2,0)
    mh.setCreatedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mh.setModifiedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mc = libsbml.ModelCreator()
    mc.setFamilyName("Keating")
    mc.setGivenName("Sarah")
    mh.addCreator(mc)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mh = None
    mc = None
    date = None
    pass  

  def test_Validation_ModelHistory3(self):
    mh = libsbml.ModelHistory()
    self.assertTrue( mh != None )
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    date = libsbml.Date(2007,12,30,12,15,45,1,2,0)
    mh.setCreatedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mh.setModifiedDate(date)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mc = libsbml.ModelCreator()
    mc.setFamilyName("Keating")
    mh.addCreator(mc)
    self.assertEqual( False, (mh.hasRequiredAttributes()) )
    mh = None
    mc = None
    date = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestValidation))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
