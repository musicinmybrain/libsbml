# @file    TestRule.rb
# @brief   Rule unit tests
#
# @author  Akiya Jouraku (Ruby conversion)
# @author  Ben Bornstein 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestRule.c
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
require 'test/unit'
require 'libSBML'

class TestRule < Test::Unit::TestCase

  def setup
    @@r = LibSBML::AlgebraicRule.new(2,4)
    if (@@r == nil)
    end
  end

  def teardown
    @@r = nil
  end

  def test_Rule_init
    assert( @@r.getTypeCode() == LibSBML::SBML_ALGEBRAIC_RULE )
    assert( @@r.getMetaId() == "" )
    assert( @@r.getNotes() == nil )
    assert( @@r.getAnnotation() == nil )
    assert( @@r.getFormula() == "" )
    assert( @@r.getMath() == nil )
  end

  def test_Rule_setFormula
    formula =  "k1*X0";
    @@r.setFormula(formula)
    assert (( formula == @@r.getFormula() ))
    assert( @@r.isSetFormula() == true )
    if (@@r.getFormula() == formula)
    end
    @@r.setFormula(@@r.getFormula())
    assert (( formula == @@r.getFormula() ))
    @@r.setFormula( "")
    assert( @@r.isSetFormula() == false )
    if (@@r.getFormula() != nil)
    end
  end

  def test_Rule_setMath
    math = LibSBML::parseFormula("1 + 1")
    @@r.setMath(math)
    assert( @@r.getMath() != math )
    assert_equal true, @@r.isSetMath()
    @@r.setMath(@@r.getMath())
    assert( @@r.getMath() != math )
    @@r.setMath(nil)
    assert_equal false, @@r.isSetMath()
    if (@@r.getMath() != nil)
    end
    math = nil
  end

end
