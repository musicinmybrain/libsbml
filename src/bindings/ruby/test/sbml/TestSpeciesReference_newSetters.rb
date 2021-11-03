# @file    TestSpeciesReference_newSetters.rb
# @brief   SpeciesReference unit tests for new set function API
#
# @author  Akiya Jouraku (Ruby conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestSpeciesReference_newSetters.c
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

class TestSpeciesReference_newSetters < Test::Unit::TestCase

  def setup
    @@sr = LibSBML::SpeciesReference.new(2,4)
    if (@@sr == nil)
    end
  end

  def teardown
    @@sr = nil
  end

  def test_SpeciesReference_setDenominator1
    i = @@sr.setDenominator(2)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( @@sr.getDenominator() == 2 )
  end

  def test_SpeciesReference_setDenominator2
    c = LibSBML::SpeciesReference.new(2,2)
    i = c.setDenominator(4)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( c.getDenominator() == 4 )
    c = nil
  end

  def test_SpeciesReference_setId1
    i = @@sr.setId( "cell")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetId()
    assert ((  "cell"  == @@sr.getId() ))
  end

  def test_SpeciesReference_setId2
    i = @@sr.setId( "1cell")
    assert( i == LibSBML::LIBSBML_INVALID_ATTRIBUTE_VALUE )
    assert_equal false, @@sr.isSetId()
  end

  def test_SpeciesReference_setId3
    c = LibSBML::SpeciesReference.new(2,1)
    i = c.setId( "cell")
    assert( i == LibSBML::LIBSBML_UNEXPECTED_ATTRIBUTE )
    assert_equal false, c.isSetId()
    c = nil
  end

  def test_SpeciesReference_setId4
    i = @@sr.setId( "cell")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetId()
    assert ((  "cell"  == @@sr.getId() ))
    i = @@sr.setId("")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetId()
  end

  def test_SpeciesReference_setName1
    i = @@sr.setName( "cell")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetName()
    i = @@sr.unsetName()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetName()
  end

  def test_SpeciesReference_setName2
    i = @@sr.setName( "1cell")
    assert( i == LibSBML::LIBSBML_INVALID_ATTRIBUTE_VALUE )
    assert_equal false, @@sr.isSetName()
    i = @@sr.unsetName()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetName()
  end

  def test_SpeciesReference_setName3
    c = LibSBML::SpeciesReference.new(2,1)
    i = c.setName( "cell")
    assert( i == LibSBML::LIBSBML_UNEXPECTED_ATTRIBUTE )
    assert_equal false, c.isSetName()
    c = nil
  end

  def test_SpeciesReference_setName4
    i = @@sr.setName( "cell")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetName()
    i = @@sr.setName("")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetName()
  end

  def test_SpeciesReference_setSpecies1
    i = @@sr.setSpecies( "mm")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetSpecies()
  end

  def test_SpeciesReference_setSpecies2
    c = LibSBML::SpeciesReference.new(2,2)
    i = c.setSpecies( "1cell")
    assert( i == LibSBML::LIBSBML_INVALID_ATTRIBUTE_VALUE )
    assert_equal false, c.isSetSpecies()
    c = nil
  end

  def test_SpeciesReference_setSpecies3
    c = LibSBML::SpeciesReference.new(2,2)
    i = c.setSpecies( "mole")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert ((  "mole" == c.getSpecies() ))
    assert_equal true, c.isSetSpecies()
    c = nil
  end

  def test_SpeciesReference_setSpecies4
    i = @@sr.setSpecies( "mm")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetSpecies()
    i = @@sr.setSpecies("")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetSpecies()
  end

  def test_SpeciesReference_setStoichiometry1
    i = @@sr.setStoichiometry(2.0)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( @@sr.getStoichiometry() == 2.0 )
  end

  def test_SpeciesReference_setStoichiometry2
    c = LibSBML::SpeciesReference.new(2,2)
    i = c.setStoichiometry(4)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( c.getStoichiometry() == 4.0 )
    c = nil
  end

  def test_SpeciesReference_setStoichiometryMath1
    sm = LibSBML::StoichiometryMath.new(2,4)
    math = LibSBML::ASTNode.new(LibSBML::AST_TIMES)
    a = LibSBML::ASTNode.new()
    b = LibSBML::ASTNode.new()
    a.setName( "a")
    b.setName( "b")
    math.addChild(a)
    math.addChild(b)
    sm.setMath(math)
    i = @@sr.setStoichiometryMath(sm)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetStoichiometryMath()
    assert( @@sr.getStoichiometry() == 1 )
    i = @@sr.unsetStoichiometryMath()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetStoichiometryMath()
    sm = nil
    math = nil
  end

  def test_SpeciesReference_setStoichiometryMath2
    sm = LibSBML::StoichiometryMath.new(2,4)
    math = LibSBML::ASTNode.new(LibSBML::AST_TIMES)
    a = LibSBML::ASTNode.new()
    a.setName( "a")
    math.addChild(a)
    sm.setMath(math)
    i = @@sr.setStoichiometryMath(sm)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal true, @@sr.isSetStoichiometryMath()
    sm = nil
    math = nil
  end

  def test_SpeciesReference_setStoichiometryMath3
    i = @@sr.setStoichiometryMath(nil)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetStoichiometryMath()
    i = @@sr.unsetStoichiometryMath()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetStoichiometryMath()
  end

  def test_SpeciesReference_setStoichiometryMath4
    sm = LibSBML::StoichiometryMath.new(2,4)
    math = nil
    sm.setMath(math)
    i = @@sr.setStoichiometryMath(sm)
    assert( i == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( @@sr.isSetStoichiometryMath() == 0 )
    assert( @@sr.getStoichiometry() == 1 )
    i = @@sr.unsetStoichiometryMath()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert_equal false, @@sr.isSetStoichiometryMath()
    sm = nil
  end

  def test_SpeciesReference_setStoichiometryMath5
    sr1 = LibSBML::SpeciesReference.new(1,2)
    sm = LibSBML::StoichiometryMath.new(2,4)
    math = LibSBML::ASTNode.new(LibSBML::AST_TIMES)
    a = LibSBML::ASTNode.new()
    b = LibSBML::ASTNode.new()
    a.setName( "a")
    b.setName( "b")
    math.addChild(a)
    math.addChild(b)
    sm.setMath(math)
    i = sr1.setStoichiometryMath(sm)
    assert( i == LibSBML::LIBSBML_UNEXPECTED_ATTRIBUTE )
    assert_equal false, sr1.isSetStoichiometryMath()
    sm = nil
    sr1 = nil
    math = nil
  end

  def test_SpeciesReference_setStoichiometryMath6
    sm = LibSBML::StoichiometryMath.new(2,1)
    math = LibSBML::parseFormula("1")
    sm.setMath(math)
    math = nil
    i = @@sr.setStoichiometryMath(sm)
    assert( i == LibSBML::LIBSBML_VERSION_MISMATCH )
    assert_equal false, @@sr.isSetStoichiometryMath()
    sm = nil
  end

  def test_SpeciesReference_setStoichiometryMath7
    sr1 = LibSBML::SpeciesReference.new(1,2)
    i = sr1.unsetStoichiometryMath()
    assert( i == LibSBML::LIBSBML_UNEXPECTED_ATTRIBUTE )
    sr1 = nil
  end

end
