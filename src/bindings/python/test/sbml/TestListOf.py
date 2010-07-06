#
# @file    TestListOf.py
# @brief   ListOf unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Ben Bornstein 
#
# $Id$
# $HeadURL$
#
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestListOf.c
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


class TestListOf(unittest.TestCase):


  def test_ListOf_clear(self):
    lo = libsbml.ListOf()
    sp = libsbml.Species(2,4)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    self.assert_( lo.size() == 5 )
    lo.clear(True)
    self.assert_( lo.size() == 0 )
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.appendAndOwn(sp)
    self.assert_( lo.size() == 5 )
    out = lo.get(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.get(1)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.get(2)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.get(3)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.get(4)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    lo.clear(False)
    self.assert_( lo.size() == 0 )
    _dummyList = [ lo ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ListOf_create(self):
    lo = libsbml.ListOf()
    self.assert_( lo.getTypeCode() == libsbml.SBML_LIST_OF )
    self.assert_( lo.getNotes() == None )
    self.assert_( lo.getAnnotation() == None )
    self.assert_( lo.getMetaId() == "" )
    self.assert_( lo.size() == 0 )
    _dummyList = [ lo ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ListOf_free_NULL(self):
    _dummyList = [ None ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ListOf_get(self):
    lo = libsbml.ListOf()
    self.assert_( lo.size() == 0 )
    sp = libsbml.Species(2,4)
    lo.append(sp)
    self.assert_( lo.size() == 1 )
    out = lo.get(1)
    self.assert_( sp != out )
    _dummyList = [ sp ]; _dummyList[:] = []; del _dummyList
    _dummyList = [ lo ]; _dummyList[:] = []; del _dummyList
    pass  

  def test_ListOf_remove(self):
    lo = libsbml.ListOf()
    sp = libsbml.Species(2,4)
    self.assert_( lo.size() == 0 )
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    self.assert_( lo.size() == 5 )
    out = lo.remove(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.remove(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.remove(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.remove(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    out = lo.remove(0)
    _dummyList = [ out ]; _dummyList[:] = []; del _dummyList
    self.assert_( lo.size() == 0 )
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.append(sp)
    lo.appendAndOwn(sp)
    self.assert_( lo.size() == 5 )
    _dummyList = [ lo ]; _dummyList[:] = []; del _dummyList
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestListOf))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
