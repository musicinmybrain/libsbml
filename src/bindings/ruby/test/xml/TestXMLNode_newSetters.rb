# @file    TestXMLNode_newSetters.rb
# @brief   XMLNode unit tests
#
# @author  Akiya Jouraku (Ruby conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestXMLNode_newSetters.c
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

class TestXMLNode_newSetters < Test::Unit::TestCase

  def test_XMLNode_accessWithNULL
    assert( nil.addAttr(nil,nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.addAttr(nil,nil,nil,nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.addAttr(nil,nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.addChild(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.addNamespace(nil,nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.clearAttributes() == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.clearNamespaces() == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.clone() == nil )
    assert( LibSBML::XMLNode.convertStringToXMLNode(nil,nil) == nil )
    assert( nil.convertXMLNodeToString() == nil )
    assert( LibSBML::XMLNode.new(nil) == nil )
    assert( LibSBML::XMLNode.new(nil) == nil )
    assert( LibSBML::XMLNode.new(nil,nil) == nil )
    assert( LibSBML::XMLNode.new(nil,nil,nil) == nil )
    assert( nil.equals(nil) == 1 )
    text = LibSBML::XMLNode.new(nil)
    assert( nil.equals(text) == 0 )
    text = nil
    assert( nil.getAttributes() == nil )
    assert( nil.getAttributesLength() == 0 )
    assert( nil.getAttrIndex(nil,nil) == -1 )
    assert( nil.getAttrIndex(nil) == -1 )
    assert( nil.getAttrName(0) == nil )
    assert( nil.getAttrPrefix(0) == "" )
    assert( nil.getAttrPrefixedName(0) == "" )
    assert( nil.getAttrURI(0) == "" )
    assert( nil.getAttrValue(0) == "" )
    assert( nil.getAttrValue(nil) == "" )
    assert( nil.getAttrValue(nil,nil) == "" )
    assert( nil.getAttrValue(nil) == "" )
    assert( nil.getCharacters() == nil )
    assert( nil.getChild(0) == nil )
    assert( nil.getChildForName(nil) == nil )
    assert( nil.getChildForNameNC(nil) == nil )
    assert( nil.getChildNC(0) == nil )
    assert( nil.getIndex(nil) == -1 )
    assert( nil.getName() == "" )
    assert( nil.getNamespaceIndex(nil) == -1 )
    assert( nil.getNamespaceIndexByPrefix(nil) == -1 )
    assert( nil.getNamespacePrefix(0) == "" )
    assert( nil.getNamespacePrefix(nil) == "" )
    assert( nil.getNamespaces() == nil )
    assert( nil.getNamespacesLength() == 0 )
    assert( nil.getNamespaceURI(0) == "" )
    assert( nil.getNamespaceURI(nil) == "" )
    assert( nil.getNumChildren() == 0 )
    assert( nil.getPrefix() == "" )
    assert( nil.getURI() == "" )
    assert( nil.hasAttr(0) == false )
    assert( nil.hasAttr(nil) == false )
    assert( nil.hasAttr(nil,nil) == false )
    assert( nil.hasAttr(nil) == false )
    assert( nil.hasChild(nil) == 0 )
    assert( nil.hasNamespaceNS(nil,nil) == false )
    assert( nil.hasNamespacePrefix(nil) == false )
    assert( nil.hasNamespaceURI(nil) == false )
    assert( nil.insertChild(0,nil) == nil )
    assert( nil.isAttributesEmpty() == false )
    assert( nil.isElement() == false )
    assert( nil.isEnd() == false )
    assert( nil.isEndFor(nil) == false )
    assert( nil.isEOF() == false )
    assert( nil.isNamespacesEmpty() == false )
    assert( nil.isStart() == false )
    assert( nil.isText() == false )
    assert( nil.removeAttr(0) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeAttr(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeAttr(nil,nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeAttr(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeChild(0) == nil )
    assert( nil.removeChildren() == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeNamespace(0) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.removeNamespace(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.setAttributes(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.setEnd() == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.setEOF() == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.setNamespaces(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.setTriple(nil) == LibSBML::LIBSBML_INVALID_OBJECT )
    assert( nil.toXMLString() == nil )
    assert( nil.unsetEnd() == LibSBML::LIBSBML_INVALID_OBJECT )
  end

  def test_XMLNode_addChild1
    node = LibSBML::XMLNode.new()
    node2 = LibSBML::XMLNode.new()
    i = node.addChild(node2)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getNumChildren() == 1 )
    node = nil
    node2 = nil
  end

  def test_XMLNode_addChild2
    triple = LibSBML::XMLTriple.new("test","","")
    attr = LibSBML::XMLAttributes.new()
    node = LibSBML::XMLNode.new(triple,attr)
    node2 = LibSBML::XMLNode.new()
    i = node.addChild(node2)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getNumChildren() == 1 )
    triple = nil
    attr = nil
    node = nil
    node2 = nil
  end

  def test_XMLNode_addChild3
    triple = LibSBML::XMLTriple.new("test","","")
    node = LibSBML::XMLNode.new(triple)
    node2 = LibSBML::XMLNode.new()
    i = node.addChild(node2)
    assert( i == LibSBML::LIBSBML_INVALID_XML_OPERATION )
    assert( node.getNumChildren() == 0 )
    triple = nil
    node = nil
    node2 = nil
  end

  def test_XMLNode_clearAttributes
    triple = LibSBML::XMLTriple.new("test","","")
    attr = LibSBML::XMLAttributes.new()
    node = LibSBML::XMLNode.new(triple,attr)
    xt2 = LibSBML::XMLTriple.new("name3",+ "http://name3.org/", "p3")
    xt1 = LibSBML::XMLTriple.new("name5",+ "http://name5.org/", "p5")
    i = node.addAttr( "name1", "val1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 1 )
    i = node.addAttr( "name2", "val2",+ "http://name1.org/", "p1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 2 )
    i = node.addAttr(xt2, "val2")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 3 )
    i = node.addAttr( "name4", "val4")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 4 )
    i = node.clearAttributes()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 0 )
    xt1 = nil
    xt2 = nil
    triple = nil
    attr = nil
    node = nil
  end

  def test_XMLNode_clearNamespaces
    triple = LibSBML::XMLTriple.new("test","","")
    attr = LibSBML::XMLAttributes.new()
    node = LibSBML::XMLNode.new(triple,attr)
    i = node.addNamespace( "http://test1.org/", "test1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 1 )
    i = node.addNamespace( "http://test2.org/", "test2")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 2 )
    i = node.clearNamespaces()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 0 )
    triple = nil
    attr = nil
    node = nil
  end

  def test_XMLNode_removeAttributes
    triple = LibSBML::XMLTriple.new("test","","")
    attr = LibSBML::XMLAttributes.new()
    node = LibSBML::XMLNode.new(triple,attr)
    xt2 = LibSBML::XMLTriple.new("name3",+ "http://name3.org/", "p3")
    xt1 = LibSBML::XMLTriple.new("name5",+ "http://name5.org/", "p5")
    i = node.addAttr( "name1", "val1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 1 )
    i = node.addAttr( "name2", "val2",+ "http://name1.org/", "p1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 2 )
    i = node.addAttr(xt2, "val2")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 3 )
    i = node.addAttr( "name4", "val4")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 4 )
    i = node.removeAttr(7)
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    i = node.removeAttr( "name7")
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    i = node.removeAttr( "name7", "namespaces7")
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    i = node.removeAttr(xt1)
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    assert( node.getAttributes().getLength() == 4 )
    i = node.removeAttr(3)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 3 )
    i = node.removeAttr( "name1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 2 )
    i = node.removeAttr( "name2", "http://name1.org/")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 1 )
    i = node.removeAttr(xt2)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getAttributes().getLength() == 0 )
    xt1 = nil
    xt2 = nil
    triple = nil
    attr = nil
    node = nil
  end

  def test_XMLNode_removeChildren
    node = LibSBML::XMLNode.new()
    node2 = LibSBML::XMLNode.new()
    node3 = LibSBML::XMLNode.new()
    node.addChild(node2)
    node.addChild(node3)
    assert( node.getNumChildren() == 2 )
    i = node.removeChildren()
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( node.getNumChildren() == 0 )
    node = nil
    node2 = nil
    node3 = nil
  end

  def test_XMLNode_removeNamespaces
    triple = LibSBML::XMLTriple.new("test","","")
    attr = LibSBML::XMLAttributes.new()
    node = LibSBML::XMLNode.new(triple,attr)
    i = node.addNamespace( "http://test1.org/", "test1")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 1 )
    i = node.addNamespace( "http://test2.org/", "test2")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 2 )
    i = node.removeNamespace(7)
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    nms = node.getNamespaces()
    assert( nms.getLength() == 2 )
    i = node.removeNamespace( "name7")
    assert( i == LibSBML::LIBSBML_INDEX_EXCEEDS_SIZE )
    nms = node.getNamespaces()
    assert( nms.getLength() == 2 )
    i = node.removeNamespace(0)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 1 )
    i = node.removeNamespace( "test2")
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    nms = node.getNamespaces()
    assert( nms.getLength() == 0 )
    triple = nil
    attr = nil
    node = nil
  end

end
