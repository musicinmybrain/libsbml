#
# @file    TestRequiredElements.py
# @brief   Test hasRequiredElements unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestRequiredElements.cpp
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


class TestRequiredElements(unittest.TestCase):


  def test_AlgebraicRule(self):
    ar = libsbml.AlgebraicRule(2,4)
    self.assertEqual( False, (ar.hasRequiredElements()) )
    math = libsbml.parseFormula("ar")
    ar.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, ar.hasRequiredElements() )
    ar = None
    pass  

  def test_AssignmentRule(self):
    r = libsbml.AssignmentRule(2,4)
    self.assertEqual( False, (r.hasRequiredElements()) )
    math = libsbml.parseFormula("ar")
    r.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, r.hasRequiredElements() )
    r = None
    pass  

  def test_Compartment(self):
    c = libsbml.Compartment(2,4)
    self.assertEqual( True, c.hasRequiredElements() )
    c = None
    pass  

  def test_CompartmentType(self):
    ct = libsbml.CompartmentType(2,4)
    self.assertEqual( True, ct.hasRequiredElements() )
    ct = None
    pass  

  def test_Constraint(self):
    c = libsbml.Constraint(2,4)
    self.assertEqual( False, (c.hasRequiredElements()) )
    math = libsbml.parseFormula("a+b")
    c.setMath(math)
    self.assertEqual( True, c.hasRequiredElements() )
    c = None
    math = None
    pass  

  def test_Delay(self):
    d = libsbml.Delay(2,4)
    self.assertEqual( False, (d.hasRequiredElements()) )
    math = libsbml.parseFormula("a+b")
    d.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, d.hasRequiredElements() )
    d = None
    pass  

  def test_Event(self):
    e = libsbml.Event(2,4)
    self.assertEqual( False, (e.hasRequiredElements()) )
    t = libsbml.Trigger(2,4)
    math = libsbml.parseFormula("true")
    t.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    e.setTrigger(t)
    self.assertEqual( False, (e.hasRequiredElements()) )
    e.createEventAssignment()
    self.assertEqual( True, e.hasRequiredElements() )
    e = None
    t = None
    pass  

  def test_EventAssignment(self):
    ea = libsbml.EventAssignment(2,4)
    self.assertEqual( False, (ea.hasRequiredElements()) )
    math = libsbml.parseFormula("fd")
    ea.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, ea.hasRequiredElements() )
    ea = None
    pass  

  def test_FunctionDefinition(self):
    fd = libsbml.FunctionDefinition(2,4)
    self.assertEqual( False, (fd.hasRequiredElements()) )
    math = libsbml.parseFormula("fd")
    fd.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, fd.hasRequiredElements() )
    fd = None
    pass  

  def test_InitialAssignment(self):
    ia = libsbml.InitialAssignment(2,4)
    self.assertEqual( False, (ia.hasRequiredElements()) )
    math = libsbml.parseFormula("ia")
    ia.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, ia.hasRequiredElements() )
    ia = None
    pass  

  def test_KineticLaw(self):
    kl = libsbml.KineticLaw(2,4)
    self.assertEqual( False, (kl.hasRequiredElements()) )
    math = libsbml.parseFormula("kl")
    kl.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, kl.hasRequiredElements() )
    kl = None
    pass  

  def test_Model(self):
    m = libsbml.Model(2,4)
    self.assertEqual( True, m.hasRequiredElements() )
    m = None
    pass  

  def test_Model_L1V1(self):
    m = libsbml.Model(1,1)
    self.assertEqual( False, (m.hasRequiredElements()) )
    m.createCompartment()
    self.assertEqual( False, (m.hasRequiredElements()) )
    m.createSpecies()
    self.assertEqual( False, (m.hasRequiredElements()) )
    m.createReaction()
    self.assertEqual( True, m.hasRequiredElements() )
    m = None
    pass  

  def test_Model_L1V2(self):
    m = libsbml.Model(1,2)
    self.assertEqual( False, (m.hasRequiredElements()) )
    m.createCompartment()
    self.assertEqual( True, m.hasRequiredElements() )
    m = None
    pass  

  def test_ModifierSpeciesReference(self):
    msr = libsbml.ModifierSpeciesReference(2,4)
    self.assertEqual( True, msr.hasRequiredElements() )
    msr = None
    pass  

  def test_Parameter(self):
    p = libsbml.Parameter(2,4)
    self.assertEqual( True, p.hasRequiredElements() )
    p = None
    pass  

  def test_RateRule(self):
    r = libsbml.RateRule(2,4)
    self.assertEqual( False, (r.hasRequiredElements()) )
    math = libsbml.parseFormula("ar")
    r.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, r.hasRequiredElements() )
    r = None
    pass  

  def test_Reaction(self):
    r = libsbml.Reaction(2,4)
    self.assertEqual( True, r.hasRequiredElements() )
    r = None
    pass  

  def test_Species(self):
    s = libsbml.Species(2,4)
    self.assertEqual( True, s.hasRequiredElements() )
    s = None
    pass  

  def test_SpeciesReference(self):
    sr = libsbml.SpeciesReference(2,4)
    self.assertEqual( True, sr.hasRequiredElements() )
    sr = None
    pass  

  def test_SpeciesType(self):
    st = libsbml.SpeciesType(2,4)
    self.assertEqual( True, st.hasRequiredElements() )
    st = None
    pass  

  def test_StoichiometryMath(self):
    sm = libsbml.StoichiometryMath(2,4)
    self.assertEqual( False, (sm.hasRequiredElements()) )
    math = libsbml.parseFormula("ar")
    sm.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, sm.hasRequiredElements() )
    sm = None
    pass  

  def test_Trigger(self):
    t = libsbml.Trigger(2,4)
    self.assertEqual( False, (t.hasRequiredElements()) )
    math = libsbml.parseFormula("ar")
    t.setMath(math)
    _dummyList = [ math ]; _dummyList[:] = []; del _dummyList
    self.assertEqual( True, t.hasRequiredElements() )
    t = None
    pass  

  def test_Unit(self):
    u = libsbml.Unit(2,4)
    self.assertEqual( True, u.hasRequiredElements() )
    u = None
    pass  

  def test_UnitDefinition(self):
    ud = libsbml.UnitDefinition(2,4)
    self.assertEqual( False, (ud.hasRequiredElements()) )
    ud.createUnit()
    self.assertEqual( True, ud.hasRequiredElements() )
    ud = None
    pass  

  def test_UnitDefinition_L1(self):
    ud = libsbml.UnitDefinition(1,2)
    self.assertEqual( True, ud.hasRequiredElements() )
    ud = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestRequiredElements))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
