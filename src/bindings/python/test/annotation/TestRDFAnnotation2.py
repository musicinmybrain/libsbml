#
# @file    TestRDFAnnotation2.py
# @brief   fomula units data unit tests
#
# @author  Akiya Jouraku (Python conversion)
# @author  Ben Bornstein 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestRDFAnnotation2.cpp
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

def wrapString(s):
  return s
  pass


class TestRDFAnnotation2(unittest.TestCase):

  global m2
  m2 = None
  global d2
  d2 = None

  def equals(self, *x):
    if len(x) == 2:
      return x[0] == x[1]
    elif len(x) == 1:
      return x[0] == self.OSS.str()

  def setUp(self):
    filename = "../../sbml/annotation/test/test-data/annotation2.xml"
    self.d2 = libsbml.readSBML(filename)
    self.m2 = self.d2.getModel()
    filename = None
    pass  

  def tearDown(self):
    self.d2 = None
    pass  

  def test_RDFAnnotation2_getModelHistory(self):
    history = self.m2.getModelHistory()
    self.assertTrue( history != None )
    mc = history.getCreator(0)
    self.assertTrue((  "Hucka" == mc.getFamilyName() ))
    self.assertTrue((  "Mike" == mc.getGivenName() ))
    self.assertTrue((  "mhucka@caltech.edu" == mc.getEmail() ))
    self.assertTrue((  "BNMC" == mc.getOrganisation() ))
    mc1 = history.getCreator(1)
    self.assertTrue((  "Keating" == mc1.getFamilyName() ))
    self.assertTrue((  "Sarah" == mc1.getGivenName() ))
    self.assertTrue((  "skeating@caltech.edu" == mc1.getEmail() ))
    self.assertTrue((  "UH" == mc1.getOrganisation() ))
    date = history.getCreatedDate()
    self.assertTrue( date.getYear() == 2005 )
    self.assertTrue( date.getMonth() == 2 )
    self.assertTrue( date.getDay() == 2 )
    self.assertTrue( date.getHour() == 14 )
    self.assertTrue( date.getMinute() == 56 )
    self.assertTrue( date.getSecond() == 11 )
    self.assertTrue( date.getSignOffset() == 0 )
    self.assertTrue( date.getHoursOffset() == 0 )
    self.assertTrue( date.getMinutesOffset() == 0 )
    self.assertTrue((  "2005-02-02T14:56:11Z" == date.getDateAsString() ))
    date = history.getModifiedDate()
    self.assertTrue( date.getYear() == 2006 )
    self.assertTrue( date.getMonth() == 5 )
    self.assertTrue( date.getDay() == 30 )
    self.assertTrue( date.getHour() == 10 )
    self.assertTrue( date.getMinute() == 46 )
    self.assertTrue( date.getSecond() == 2 )
    self.assertTrue( date.getSignOffset() == 0 )
    self.assertTrue( date.getHoursOffset() == 0 )
    self.assertTrue( date.getMinutesOffset() == 0 )
    self.assertTrue((  "2006-05-30T10:46:02Z" == date.getDateAsString() ))
    date = history.getModifiedDate(1)
    self.assertTrue( date.getYear() == 2007 )
    self.assertTrue( date.getMonth() == 1 )
    self.assertTrue( date.getDay() == 16 )
    self.assertTrue( date.getHour() == 15 )
    self.assertTrue( date.getMinute() == 31 )
    self.assertTrue( date.getSecond() == 52 )
    self.assertTrue( date.getSignOffset() == 0 )
    self.assertTrue( date.getHoursOffset() == 0 )
    self.assertTrue( date.getMinutesOffset() == 0 )
    self.assertTrue((  "2007-01-16T15:31:52Z" == date.getDateAsString() ))
    pass  

  def test_RDFAnnotation2_modelWithHistoryAndCVTerms(self):
    h = libsbml.ModelHistory()
    c = libsbml.ModelCreator()
    c.setFamilyName("Keating")
    c.setGivenName("Sarah")
    h.addCreator(c)
    d = libsbml.Date(2008,11,17,18,37,0,0,0,0)
    h.setCreatedDate(d)
    h.setModifiedDate(d)
    self.m2.unsetModelHistory()
    self.m2.setModelHistory(h)
    cv = libsbml.CVTerm()
    cv.setQualifierType(libsbml.BIOLOGICAL_QUALIFIER)
    cv.setBiologicalQualifierType(libsbml.BQB_IS_VERSION_OF)
    cv.addResource("http://www.geneontology.org/#GO:0005892")
    self.m2.addCVTerm(cv)
    ann = libsbml.RDFAnnotationParser.parseModelHistory(self.m2)
    expected = wrapString("<annotation>\n" + 
    "  <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "    <rdf:Description rdf:about=\"#_000001\">\n" + 
    "      <dc:creator rdf:parseType=\"Resource\">\n" + 
    "        <rdf:Bag>\n" + 
    "          <rdf:li rdf:parseType=\"Resource\">\n" + 
    "            <vCard:N rdf:parseType=\"Resource\">\n" + 
    "              <vCard:Family>Keating</vCard:Family>\n" + 
    "              <vCard:Given>Sarah</vCard:Given>\n" + 
    "            </vCard:N>\n" + 
    "          </rdf:li>\n" + 
    "        </rdf:Bag>\n" + 
    "      </dc:creator>\n" + 
    "      <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2008-11-17T18:37:00Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:created>\n" + 
    "      <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2008-11-17T18:37:00Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:modified>\n" + 
    "      <bqbiol:isVersionOf>\n" + 
    "        <rdf:Bag>\n" + 
    "          <rdf:li rdf:resource=\"http://www.geneontology.org/#GO:0005892\"/>\n" + 
    "        </rdf:Bag>\n" + 
    "      </bqbiol:isVersionOf>\n" + 
    "    </rdf:Description>\n" + 
    "  </rdf:RDF>\n" + 
    "</annotation>")
    if (ann != None):
      self.assertEqual( True, self.equals(expected,ann.toXMLString()) )
      pass    
      pass    
    c = None
    d = None
    h = None
    cv = None
    ann = None
    pass  

  def test_RDFAnnotation2_modelWithHistoryAndMultipleModifiedDates(self):
    h = libsbml.ModelHistory()
    c = libsbml.ModelCreator()
    c.setFamilyName("Keating")
    c.setGivenName("Sarah")
    h.addCreator(c)
    d = libsbml.Date(2005,2,2,14,56,11)
    h.setCreatedDate(d)
    h.addModifiedDate(d)
    h.addModifiedDate(d)
    self.m2.unsetModelHistory()
    self.m2.setModelHistory(h)
    ann = libsbml.RDFAnnotationParser.parseModelHistory(self.m2)
    expected = wrapString("<annotation>\n" + 
    "  <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "    <rdf:Description rdf:about=\"#_000001\">\n" + 
    "      <dc:creator rdf:parseType=\"Resource\">\n" + 
    "        <rdf:Bag>\n" + 
    "          <rdf:li rdf:parseType=\"Resource\">\n" + 
    "            <vCard:N rdf:parseType=\"Resource\">\n" + 
    "              <vCard:Family>Keating</vCard:Family>\n" + 
    "              <vCard:Given>Sarah</vCard:Given>\n" + 
    "            </vCard:N>\n" + 
    "          </rdf:li>\n" + 
    "        </rdf:Bag>\n" + 
    "      </dc:creator>\n" + 
    "      <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2005-02-02T14:56:11Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:created>\n" + 
    "      <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2005-02-02T14:56:11Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:modified>\n" + 
    "      <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2005-02-02T14:56:11Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:modified>\n" + 
    "    </rdf:Description>\n" + 
    "  </rdf:RDF>\n" + 
    "</annotation>")
    self.assertEqual( True, self.equals(expected,ann.toXMLString()) )
    c = None
    d = None
    h = None
    ann = None
    pass  

  def test_RDFAnnotation2_modelWithHistoryWithCharacterReference(self):
    h = libsbml.ModelHistory()
    c = libsbml.ModelCreator()
    c.setFamilyName("Dr&#228;ger")
    c.setGivenName("Andreas")
    h.addCreator(c)
    d = libsbml.Date(2005,2,2,14,56,11)
    h.setCreatedDate(d)
    h.addModifiedDate(d)
    self.m2.unsetModelHistory()
    self.m2.setModelHistory(h)
    ann = libsbml.RDFAnnotationParser.parseModelHistory(self.m2)
    expected = wrapString("<annotation>\n" + 
    "  <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "    <rdf:Description rdf:about=\"#_000001\">\n" + 
    "      <dc:creator rdf:parseType=\"Resource\">\n" + 
    "        <rdf:Bag>\n" + 
    "          <rdf:li rdf:parseType=\"Resource\">\n" + 
    "            <vCard:N rdf:parseType=\"Resource\">\n" + 
    "              <vCard:Family>Dr&#228;ger</vCard:Family>\n" + 
    "              <vCard:Given>Andreas</vCard:Given>\n" + 
    "            </vCard:N>\n" + 
    "          </rdf:li>\n" + 
    "        </rdf:Bag>\n" + 
    "      </dc:creator>\n" + 
    "      <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2005-02-02T14:56:11Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:created>\n" + 
    "      <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "        <dcterms:W3CDTF>2005-02-02T14:56:11Z</dcterms:W3CDTF>\n" + 
    "      </dcterms:modified>\n" + 
    "    </rdf:Description>\n" + 
    "  </rdf:RDF>\n" + 
    "</annotation>")
    self.assertEqual( True, self.equals(expected,ann.toXMLString()) )
    c = None
    d = None
    h = None
    ann = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestRDFAnnotation2))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)
