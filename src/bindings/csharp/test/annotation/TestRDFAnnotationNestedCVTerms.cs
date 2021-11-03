///  @file    TestRDFAnnotationNestedCVTerms.cs
///  @brief   Tests for reading/writing nested annotation
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Sarah Keating 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestRDFAnnotationNestedCVTerms.cpp
///  using the conversion program dev/utilities/translateTests/translateTests.pl.
///  Any changes made here will be lost the next time the file is regenerated.
/// 
///  -----------------------------------------------------------------------------
///  This file is part of libSBML.  Please visit http://sbml.org for more
///  information about SBML, and the latest version of libSBML.
/// 
///  Copyright 2005-2010 California Institute of Technology.
///  Copyright 2002-2005 California Institute of Technology and
///                      Japan Science and Technology Corporation.
///  
///  This library is free software; you can redistribute it and/or modify it
///  under the terms of the GNU Lesser General Public License as published by
///  the Free Software Foundation.  A copy of the license agreement is provided
///  in the file named "LICENSE.txt" included with this software distribution
///  and also available online as http://sbml.org/software/libsbml/license.html
///  -----------------------------------------------------------------------------


namespace LibSBMLCSTest.annotation {

  using libsbmlcs;

  using System;

  using System.IO;

  public class TestRDFAnnotationNestedCVTerms {
    public class AssertionError : System.Exception 
    {
      public AssertionError() : base()
      {
        
      }
    }


    static void assertTrue(bool condition)
    {
      if (condition == true)
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        return;
      }
      else if ( (a == null) || (b == null) )
      {
        throw new AssertionError();
      }
      else if (a.Equals(b))
      {
        return;
      }
  
      throw new AssertionError();
    }

    static void assertNotEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        throw new AssertionError();
      }
      else if ( (a == null) || (b == null) )
      {
        return;
      }
      else if (a.Equals(b))
      {
        throw new AssertionError();
      }
    }

    static void assertEquals(bool a, bool b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(bool a, bool b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(int a, int b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(int a, int b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }

    private Model m31;
    private SBMLDocument d32;
    private SBMLDocument d31;
    private SBMLDocument d;
    private Model m32;
    private Model m;

    public void setUp()
    {
      string filename = "../../sbml/annotation/test/test-data/annotationNested-l2v5.xml";
      string filename31 = "../../sbml/annotation/test/test-data/annotationNested-l3v1.xml";
      string filename32 = "../../sbml/annotation/test/test-data/annotationNested-l3v2.xml";
      d = libsbml.readSBML(filename);
      m = d.getModel();
      d31 = libsbml.readSBML(filename31);
      m31 = d31.getModel();
      d32 = libsbml.readSBML(filename32);
      m32 = d32.getModel();
    }

    public void tearDown()
    {
    }

    public void test_RDFAnnotationNestedCVTerm_dcterms()
    {
      XMLNode node = RDFAnnotationParser.parseModelHistory(m);
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 3 );
      XMLNode creator = desc.getChild(0);
      assertTrue((  "creator" == creator.getName() ));
      assertTrue((  "dcterms" == creator.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == creator.getURI() ));
      assertTrue( creator.getNumChildren() == 1 );
      XMLNode Bag = creator.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 1 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 3 );
      XMLNode N = li.getChild(0);
      assertTrue((  "N" == N.getName() ));
      assertTrue((  "vCard" == N.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == N.getURI() ));
      assertTrue( N.getNumChildren() == 2 );
      XMLNode Family = N.getChild(0);
      assertTrue((  "Family" == Family.getName() ));
      assertTrue((  "vCard" == Family.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Family.getURI() ));
      assertTrue( Family.getNumChildren() == 1 );
      XMLNode Given = N.getChild(1);
      assertTrue((  "Given" == Given.getName() ));
      assertTrue((  "vCard" == Given.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Given.getURI() ));
      assertTrue( Given.getNumChildren() == 1 );
      XMLNode EMAIL = li.getChild(1);
      assertTrue((  "EMAIL" == EMAIL.getName() ));
      assertTrue((  "vCard" == EMAIL.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == EMAIL.getURI() ));
      assertTrue( EMAIL.getNumChildren() == 1 );
      XMLNode ORG = li.getChild(2);
      assertTrue((  "ORG" == ORG.getName() ));
      assertTrue((  "vCard" == ORG.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == ORG.getURI() ));
      assertTrue( ORG.getNumChildren() == 1 );
      XMLNode Orgname = ORG.getChild(0);
      assertTrue((  "Orgname" == Orgname.getName() ));
      assertTrue((  "vCard" == Orgname.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Orgname.getURI() ));
      assertTrue( Orgname.getNumChildren() == 1 );
      XMLNode created = desc.getChild(1);
      assertTrue((  "created" == created.getName() ));
      assertTrue((  "dcterms" == created.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == created.getURI() ));
      assertTrue( created.getNumChildren() == 1 );
      XMLNode cr_date = created.getChild(0);
      assertTrue((  "W3CDTF" == cr_date.getName() ));
      assertTrue((  "dcterms" == cr_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == cr_date.getURI() ));
      assertTrue( cr_date.getNumChildren() == 1 );
      XMLNode modified = desc.getChild(2);
      assertTrue((  "modified" == modified.getName() ));
      assertTrue((  "dcterms" == modified.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == modified.getURI() ));
      assertTrue( modified.getNumChildren() == 1 );
      XMLNode mo_date = created.getChild(0);
      assertTrue((  "W3CDTF" == mo_date.getName() ));
      assertTrue((  "dcterms" == mo_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == mo_date.getURI() ));
      assertTrue( mo_date.getNumChildren() == 1 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_dcterms_31()
    {
      XMLNode node = RDFAnnotationParser.parseModelHistory(m31);
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 3 );
      XMLNode creator = desc.getChild(0);
      assertTrue((  "creator" == creator.getName() ));
      assertTrue((  "dcterms" == creator.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == creator.getURI() ));
      assertTrue( creator.getNumChildren() == 1 );
      XMLNode Bag = creator.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 1 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 3 );
      XMLNode N = li.getChild(0);
      assertTrue((  "N" == N.getName() ));
      assertTrue((  "vCard" == N.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == N.getURI() ));
      assertTrue( N.getNumChildren() == 2 );
      XMLNode Family = N.getChild(0);
      assertTrue((  "Family" == Family.getName() ));
      assertTrue((  "vCard" == Family.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Family.getURI() ));
      assertTrue( Family.getNumChildren() == 1 );
      XMLNode Given = N.getChild(1);
      assertTrue((  "Given" == Given.getName() ));
      assertTrue((  "vCard" == Given.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Given.getURI() ));
      assertTrue( Given.getNumChildren() == 1 );
      XMLNode EMAIL = li.getChild(1);
      assertTrue((  "EMAIL" == EMAIL.getName() ));
      assertTrue((  "vCard" == EMAIL.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == EMAIL.getURI() ));
      assertTrue( EMAIL.getNumChildren() == 1 );
      XMLNode ORG = li.getChild(2);
      assertTrue((  "ORG" == ORG.getName() ));
      assertTrue((  "vCard" == ORG.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == ORG.getURI() ));
      assertTrue( ORG.getNumChildren() == 1 );
      XMLNode Orgname = ORG.getChild(0);
      assertTrue((  "Orgname" == Orgname.getName() ));
      assertTrue((  "vCard" == Orgname.getPrefix() ));
      assertTrue((  "http://www.w3.org/2001/vcard-rdf/3.0#" == Orgname.getURI() ));
      assertTrue( Orgname.getNumChildren() == 1 );
      XMLNode created = desc.getChild(1);
      assertTrue((  "created" == created.getName() ));
      assertTrue((  "dcterms" == created.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == created.getURI() ));
      assertTrue( created.getNumChildren() == 1 );
      XMLNode cr_date = created.getChild(0);
      assertTrue((  "W3CDTF" == cr_date.getName() ));
      assertTrue((  "dcterms" == cr_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == cr_date.getURI() ));
      assertTrue( cr_date.getNumChildren() == 1 );
      XMLNode modified = desc.getChild(2);
      assertTrue((  "modified" == modified.getName() ));
      assertTrue((  "dcterms" == modified.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == modified.getURI() ));
      assertTrue( modified.getNumChildren() == 1 );
      XMLNode mo_date = created.getChild(0);
      assertTrue((  "W3CDTF" == mo_date.getName() ));
      assertTrue((  "dcterms" == mo_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == mo_date.getURI() ));
      assertTrue( mo_date.getNumChildren() == 1 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_dcterms_32()
    {
      XMLNode node = RDFAnnotationParser.parseModelHistory(m32);
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 3 );
      XMLNode creator = desc.getChild(0);
      assertTrue((  "creator" == creator.getName() ));
      assertTrue((  "dcterms" == creator.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == creator.getURI() ));
      assertTrue( creator.getNumChildren() == 1 );
      XMLNode Bag = creator.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 1 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 3 );
      XMLNode N = li.getChild(0);
      assertTrue((  "hasName" == N.getName() ));
      assertTrue((  "vCard4" == N.getPrefix() ));
      assertTrue((  "http://www.w3.org/2006/vcard/ns#" == N.getURI() ));
      assertTrue( N.getNumChildren() == 2 );
      XMLNode Family = N.getChild(0);
      assertTrue((  "family-name" == Family.getName() ));
      assertTrue((  "vCard4" == Family.getPrefix() ));
      assertTrue((  "http://www.w3.org/2006/vcard/ns#" == Family.getURI() ));
      assertTrue( Family.getNumChildren() == 1 );
      XMLNode Given = N.getChild(1);
      assertTrue((  "given-name" == Given.getName() ));
      assertTrue((  "vCard4" == Given.getPrefix() ));
      assertTrue((  "http://www.w3.org/2006/vcard/ns#" == Given.getURI() ));
      assertTrue( Given.getNumChildren() == 1 );
      XMLNode EMAIL = li.getChild(1);
      assertTrue((  "hasEmail" == EMAIL.getName() ));
      assertTrue((  "vCard4" == EMAIL.getPrefix() ));
      assertTrue((  "http://www.w3.org/2006/vcard/ns#" == EMAIL.getURI() ));
      assertTrue( EMAIL.getNumChildren() == 1 );
      XMLNode ORG = li.getChild(2);
      assertTrue((  "organization-name" == ORG.getName() ));
      assertTrue((  "vCard4" == ORG.getPrefix() ));
      assertTrue((  "http://www.w3.org/2006/vcard/ns#" == ORG.getURI() ));
      assertTrue( ORG.getNumChildren() == 1 );
      XMLNode created = desc.getChild(1);
      assertTrue((  "created" == created.getName() ));
      assertTrue((  "dcterms" == created.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == created.getURI() ));
      assertTrue( created.getNumChildren() == 1 );
      XMLNode cr_date = created.getChild(0);
      assertTrue((  "W3CDTF" == cr_date.getName() ));
      assertTrue((  "dcterms" == cr_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == cr_date.getURI() ));
      assertTrue( cr_date.getNumChildren() == 1 );
      XMLNode modified = desc.getChild(2);
      assertTrue((  "modified" == modified.getName() ));
      assertTrue((  "dcterms" == modified.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == modified.getURI() ));
      assertTrue( modified.getNumChildren() == 1 );
      XMLNode mo_date = created.getChild(0);
      assertTrue((  "W3CDTF" == mo_date.getName() ));
      assertTrue((  "dcterms" == mo_date.getPrefix() ));
      assertTrue((  "http://purl.org/dc/terms/" == mo_date.getURI() ));
      assertTrue( mo_date.getNumChildren() == 1 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_parseCVTerms()
    {
      XMLNode node = RDFAnnotationParser.parseCVTerms(m.getCompartment(0));
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 1 );
      XMLNode is1 = desc.getChild(0);
      assertTrue((  "is" == is1.getName() ));
      assertTrue((  "bqbiol" == is1.getPrefix() ));
      assertTrue( is1.getNumChildren() == 1 );
      XMLNode Bag = is1.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 5 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 0 );
      XMLNode li1 = Bag.getChild(1);
      assertTrue((  "li" == li1.getName() ));
      assertTrue((  "rdf" == li1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li1.getURI() ));
      assertTrue( li1.getNumChildren() == 0 );
      XMLNode li2 = Bag.getChild(2);
      assertTrue((  "li" == li2.getName() ));
      assertTrue((  "rdf" == li2.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li2.getURI() ));
      assertTrue( li2.getNumChildren() == 0 );
      XMLNode li3 = Bag.getChild(3);
      assertTrue((  "li" == li3.getName() ));
      assertTrue((  "rdf" == li3.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li3.getURI() ));
      assertTrue( li3.getNumChildren() == 0 );
      XMLNode hasPart1 = Bag.getChild(4);
      assertTrue((  "hasPart" == hasPart1.getName() ));
      assertTrue((  "bqbiol" == hasPart1.getPrefix() ));
      assertTrue( hasPart1.getNumChildren() == 1 );
      XMLNode Bag1 = hasPart1.getChild(0);
      assertTrue((  "Bag" == Bag1.getName() ));
      assertTrue((  "rdf" == Bag1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag1.getURI() ));
      assertTrue( Bag1.getNumChildren() == 1 );
      XMLNode li4 = Bag1.getChild(0);
      assertTrue((  "li" == li4.getName() ));
      assertTrue((  "rdf" == li4.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li4.getURI() ));
      assertTrue( li4.getNumChildren() == 0 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_parseCVTerms_31()
    {
      XMLNode node = RDFAnnotationParser.parseCVTerms(m31.getCompartment(0));
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 1 );
      XMLNode is1 = desc.getChild(0);
      assertTrue((  "is" == is1.getName() ));
      assertTrue((  "bqbiol" == is1.getPrefix() ));
      assertTrue( is1.getNumChildren() == 1 );
      XMLNode Bag = is1.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 5 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 0 );
      XMLNode li1 = Bag.getChild(1);
      assertTrue((  "li" == li1.getName() ));
      assertTrue((  "rdf" == li1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li1.getURI() ));
      assertTrue( li1.getNumChildren() == 0 );
      XMLNode li2 = Bag.getChild(2);
      assertTrue((  "li" == li2.getName() ));
      assertTrue((  "rdf" == li2.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li2.getURI() ));
      assertTrue( li2.getNumChildren() == 0 );
      XMLNode li3 = Bag.getChild(3);
      assertTrue((  "li" == li3.getName() ));
      assertTrue((  "rdf" == li3.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li3.getURI() ));
      assertTrue( li3.getNumChildren() == 0 );
      XMLNode hasPart1 = Bag.getChild(4);
      assertTrue((  "hasPart" == hasPart1.getName() ));
      assertTrue((  "bqbiol" == hasPart1.getPrefix() ));
      assertTrue( hasPart1.getNumChildren() == 1 );
      XMLNode Bag1 = hasPart1.getChild(0);
      assertTrue((  "Bag" == Bag1.getName() ));
      assertTrue((  "rdf" == Bag1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag1.getURI() ));
      assertTrue( Bag1.getNumChildren() == 1 );
      XMLNode li4 = Bag1.getChild(0);
      assertTrue((  "li" == li4.getName() ));
      assertTrue((  "rdf" == li4.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li4.getURI() ));
      assertTrue( li4.getNumChildren() == 0 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_parseCVTerms_32()
    {
      XMLNode node = RDFAnnotationParser.parseCVTerms(m32.getCompartment(0));
      assertTrue( node.getNumChildren() == 1 );
      XMLNode rdf = node.getChild(0);
      assertTrue((  "RDF" == rdf.getName() ));
      assertTrue((  "rdf" == rdf.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == rdf.getURI() ));
      assertTrue( rdf.getNumChildren() == 1 );
      XMLNode desc = rdf.getChild(0);
      assertTrue((  "Description" == desc.getName() ));
      assertTrue((  "rdf" == desc.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == desc.getURI() ));
      assertTrue( desc.getNumChildren() == 1 );
      XMLNode is1 = desc.getChild(0);
      assertTrue((  "is" == is1.getName() ));
      assertTrue((  "bqbiol" == is1.getPrefix() ));
      assertTrue( is1.getNumChildren() == 1 );
      XMLNode Bag = is1.getChild(0);
      assertTrue((  "Bag" == Bag.getName() ));
      assertTrue((  "rdf" == Bag.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag.getURI() ));
      assertTrue( Bag.getNumChildren() == 5 );
      XMLNode li = Bag.getChild(0);
      assertTrue((  "li" == li.getName() ));
      assertTrue((  "rdf" == li.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li.getURI() ));
      assertTrue( li.getNumChildren() == 0 );
      XMLNode li1 = Bag.getChild(1);
      assertTrue((  "li" == li1.getName() ));
      assertTrue((  "rdf" == li1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li1.getURI() ));
      assertTrue( li1.getNumChildren() == 0 );
      XMLNode li2 = Bag.getChild(2);
      assertTrue((  "li" == li2.getName() ));
      assertTrue((  "rdf" == li2.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li2.getURI() ));
      assertTrue( li2.getNumChildren() == 0 );
      XMLNode li3 = Bag.getChild(3);
      assertTrue((  "li" == li3.getName() ));
      assertTrue((  "rdf" == li3.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li3.getURI() ));
      assertTrue( li3.getNumChildren() == 0 );
      XMLNode hasPart1 = Bag.getChild(4);
      assertTrue((  "hasPart" == hasPart1.getName() ));
      assertTrue((  "bqbiol" == hasPart1.getPrefix() ));
      assertTrue( hasPart1.getNumChildren() == 1 );
      XMLNode Bag1 = hasPart1.getChild(0);
      assertTrue((  "Bag" == Bag1.getName() ));
      assertTrue((  "rdf" == Bag1.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == Bag1.getURI() ));
      assertTrue( Bag1.getNumChildren() == 1 );
      XMLNode li4 = Bag1.getChild(0);
      assertTrue((  "li" == li4.getName() ));
      assertTrue((  "rdf" == li4.getPrefix() ));
      assertTrue((  "http://www.w3.org/1999/02/22-rdf-syntax-ns#" == li4.getURI() ));
      assertTrue( li4.getNumChildren() == 0 );
      node = null;
    }

    public void test_RDFAnnotationNestedCVTerm_reading()
    {
      Compartment c = m.getCompartment(1);
      assertTrue( c.getNumCVTerms() == 1 );
      CVTerm cv = c.getCVTerm(0);
      assertTrue( cv.getNumResources() == 1 );
      assertTrue( cv.getResourceURI(0) ==  "top" );
      assertTrue( cv.getNumNestedCVTerms() == 1 );
      CVTerm cv1 = cv.getNestedCVTerm(0);
      assertTrue( cv1.getNumResources() == 1 );
      assertTrue( cv1.getResourceURI(0) ==  "nest" );
      assertTrue( cv1.getNumNestedCVTerms() == 1 );
      CVTerm cv2 = cv1.getNestedCVTerm(0);
      assertTrue( cv2.getNumResources() == 1 );
      assertTrue( cv2.getResourceURI(0) ==  "nest_nest" );
      assertTrue( cv2.getNumNestedCVTerms() == 0 );
    }

    public void test_RDFAnnotationNestedCVTerm_reading_31()
    {
      Compartment c = m31.getCompartment(1);
      assertTrue( c.getNumCVTerms() == 1 );
      CVTerm cv = c.getCVTerm(0);
      assertTrue( cv.getNumResources() == 1 );
      assertTrue( cv.getResourceURI(0) ==  "top" );
      assertTrue( cv.getNumNestedCVTerms() == 1 );
      CVTerm cv1 = cv.getNestedCVTerm(0);
      assertTrue( cv1.getNumResources() == 1 );
      assertTrue( cv1.getResourceURI(0) ==  "nest" );
      assertTrue( cv1.getNumNestedCVTerms() == 1 );
      CVTerm cv2 = cv1.getNestedCVTerm(0);
      assertTrue( cv2.getNumResources() == 1 );
      assertTrue( cv2.getResourceURI(0) ==  "nest_nest" );
      assertTrue( cv2.getNumNestedCVTerms() == 0 );
    }

    public void test_RDFAnnotationNestedCVTerm_reading_32()
    {
      Compartment c = m32.getCompartment(1);
      assertTrue( c.getNumCVTerms() == 1 );
      CVTerm cv = c.getCVTerm(0);
      assertTrue( cv.getNumResources() == 1 );
      assertTrue( cv.getResourceURI(0) ==  "top" );
      assertTrue( cv.getNumNestedCVTerms() == 1 );
      CVTerm cv1 = cv.getNestedCVTerm(0);
      assertTrue( cv1.getNumResources() == 1 );
      assertTrue( cv1.getResourceURI(0) ==  "nest" );
      assertTrue( cv1.getNumNestedCVTerms() == 1 );
      CVTerm cv2 = cv1.getNestedCVTerm(0);
      assertTrue( cv2.getNumResources() == 1 );
      assertTrue( cv2.getResourceURI(0) ==  "nest_nest" );
      assertTrue( cv2.getNumNestedCVTerms() == 0 );
    }

    public void test_RDFAnnotationNestedCVTerm_writeDC_creator()
    {
      string expected = "<model metaid=\"_000001\" id=\"EPSP_Edelstein\" name=\"Edelstein1996_EPSP_AChEvent\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_000001\">\n" + 
    "        <dcterms:creator>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:parseType=\"Resource\">\n" + 
    "              <vCard:N rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Family>Le Novere</vCard:Family>\n" + 
    "                <vCard:Given>Nicolas</vCard:Given>\n" + 
    "              </vCard:N>\n" + 
    "              <vCard:EMAIL>lenov@ebi.ac.uk</vCard:EMAIL>\n" + 
    "              <vCard:ORG rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Orgname>EMBL-EBI</vCard:Orgname>\n" + 
    "              </vCard:ORG>\n" + 
    "            </rdf:li>\n" + 
    "          </rdf:Bag>\n" + 
    "        </dcterms:creator>\n" + 
    "        <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2005-02-02T14:56:11</dcterms:W3CDTF>\n" + 
    "        </dcterms:created>\n" + 
    "        <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2006-05-30T10:46:02</dcterms:W3CDTF>\n" + 
    "        </dcterms:modified>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "</model>";
      Compartment c = m.removeCompartment(2);
      c = null;
      c = m.removeCompartment(1);
      c = null;
      c = m.removeCompartment(0);
      c = null;
      string produced = m.toSBML();
      assertEquals( true, equals(expected,produced) );
    }

    public void test_RDFAnnotationNestedCVTerm_writeDC_creator_31()
    {
      string expected = "<model metaid=\"_000001\" id=\"EPSP_Edelstein\" name=\"Edelstein1996_EPSP_AChEvent\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_000001\">\n" + 
    "        <dcterms:creator>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:parseType=\"Resource\">\n" + 
    "              <vCard:N rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Family>Le Novere</vCard:Family>\n" + 
    "                <vCard:Given>Nicolas</vCard:Given>\n" + 
    "              </vCard:N>\n" + 
    "              <vCard:EMAIL>lenov@ebi.ac.uk</vCard:EMAIL>\n" + 
    "              <vCard:ORG rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Orgname>EMBL-EBI</vCard:Orgname>\n" + 
    "              </vCard:ORG>\n" + 
    "            </rdf:li>\n" + 
    "          </rdf:Bag>\n" + 
    "        </dcterms:creator>\n" + 
    "        <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2005-02-02T14:56:11</dcterms:W3CDTF>\n" + 
    "        </dcterms:created>\n" + 
    "        <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2006-05-30T10:46:02</dcterms:W3CDTF>\n" + 
    "        </dcterms:modified>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "</model>";
      Compartment c = m31.removeCompartment(2);
      c = null;
      c = m31.removeCompartment(1);
      c = null;
      c = m31.removeCompartment(0);
      c = null;
      string produced = m31.toSBML();
      assertEquals( true, equals(expected,produced) );
    }

    public void test_RDFAnnotationNestedCVTerm_writeDC_creator_32()
    {
      string expected = "<model metaid=\"_000001\" id=\"EPSP_Edelstein\" name=\"Edelstein1996_EPSP_AChEvent\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_000001\">\n" + 
    "        <dcterms:creator>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:parseType=\"Resource\">\n" + 
    "              <vCard:N rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Family>Le Novere</vCard:Family>\n" + 
    "                <vCard:Given>Nicolas</vCard:Given>\n" + 
    "              </vCard:N>\n" + 
    "              <vCard:EMAIL>lenov@ebi.ac.uk</vCard:EMAIL>\n" + 
    "              <vCard:ORG rdf:parseType=\"Resource\">\n" + 
    "                <vCard:Orgname>EMBL-EBI</vCard:Orgname>\n" + 
    "              </vCard:ORG>\n" + 
    "            </rdf:li>\n" + 
    "          </rdf:Bag>\n" + 
    "        </dcterms:creator>\n" + 
    "        <dcterms:created rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2005-02-02T14:56:11</dcterms:W3CDTF>\n" + 
    "        </dcterms:created>\n" + 
    "        <dcterms:modified rdf:parseType=\"Resource\">\n" + 
    "          <dcterms:W3CDTF>2006-05-30T10:46:02</dcterms:W3CDTF>\n" + 
    "        </dcterms:modified>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "  <listOfCompartments/>\n" + 
    "</model>";
      Compartment c = m32.removeCompartment(2);
      c = null;
      c = m32.removeCompartment(1);
      c = null;
      c = m32.removeCompartment(0);
      c = null;
      string produced = m32.toSBML();
      assertEquals( true, equals(expected,produced) );
    }

    public void test_RDFAnnotationNestedCVTerm_writing()
    {
      string annot = "<compartment metaid=\"_4\" id=\"B\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_4\">\n" + 
    "        <bqbiol:is>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:resource=\"top\"/>\n" + 
    "            <bqbiol:hasPart>\n" + 
    "              <rdf:Bag>\n" + 
    "                <rdf:li rdf:resource=\"nest\"/>\n" + 
    "              </rdf:Bag>\n" + 
    "            </bqbiol:hasPart>\n" + 
    "          </rdf:Bag>\n" + 
    "        </bqbiol:is>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "</compartment>";
      Compartment c = m.getCompartment(2);
      assertTrue( c.getNumCVTerms() == 0 );
      CVTerm cv = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv.setBiologicalQualifierType(libsbml.BQB_IS);
      cv.addResource("top");
      CVTerm cv1 = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv1.setBiologicalQualifierType(libsbml.BQB_HAS_PART);
      cv1.addResource("nest");
      cv.addNestedCVTerm(cv1);
      cv1 = null;
      c.addCVTerm(cv);
      cv = null;
      string produced = c.toSBML();
      assertEquals( true, equals(annot,produced) );
    }

    public void test_RDFAnnotationNestedCVTerm_writing_31()
    {
      string annot = "<compartment metaid=\"_4\" id=\"B\" constant=\"true\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:vCard4=\"http://www.w3.org/2006/vcard/ns#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_4\">\n" + 
    "        <bqbiol:is>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:resource=\"top\"/>\n" + 
    "            <bqbiol:hasPart>\n" + 
    "              <rdf:Bag>\n" + 
    "                <rdf:li rdf:resource=\"nest\"/>\n" + 
    "              </rdf:Bag>\n" + 
    "            </bqbiol:hasPart>\n" + 
    "          </rdf:Bag>\n" + 
    "        </bqbiol:is>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "</compartment>";
      Compartment c = m31.getCompartment(2);
      assertTrue( c.getNumCVTerms() == 0 );
      CVTerm cv = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv.setBiologicalQualifierType(libsbml.BQB_IS);
      cv.addResource("top");
      CVTerm cv1 = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv1.setBiologicalQualifierType(libsbml.BQB_HAS_PART);
      cv1.addResource("nest");
      cv.addNestedCVTerm(cv1);
      cv1 = null;
      c.addCVTerm(cv);
      cv = null;
      string produced = c.toSBML();
      assertEquals( true, equals(annot,produced) );
    }

    public void test_RDFAnnotationNestedCVTerm_writing_32()
    {
      string annot = "<compartment metaid=\"_4\" id=\"B\" constant=\"true\">\n" + 
    "  <annotation>\n" + 
    "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:vCard=\"http://www.w3.org/2001/vcard-rdf/3.0#\" xmlns:vCard4=\"http://www.w3.org/2006/vcard/ns#\" xmlns:bqbiol=\"http://biomodels.net/biology-qualifiers/\" xmlns:bqmodel=\"http://biomodels.net/model-qualifiers/\">\n" + 
    "      <rdf:Description rdf:about=\"#_4\">\n" + 
    "        <bqbiol:is>\n" + 
    "          <rdf:Bag>\n" + 
    "            <rdf:li rdf:resource=\"top\"/>\n" + 
    "            <bqbiol:hasPart>\n" + 
    "              <rdf:Bag>\n" + 
    "                <rdf:li rdf:resource=\"nest\"/>\n" + 
    "              </rdf:Bag>\n" + 
    "            </bqbiol:hasPart>\n" + 
    "          </rdf:Bag>\n" + 
    "        </bqbiol:is>\n" + 
    "      </rdf:Description>\n" + 
    "    </rdf:RDF>\n" + 
    "  </annotation>\n" + 
    "</compartment>";
      Compartment c = m32.getCompartment(2);
      assertTrue( c.getNumCVTerms() == 0 );
      CVTerm cv = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv.setBiologicalQualifierType(libsbml.BQB_IS);
      cv.addResource("top");
      CVTerm cv1 = new CVTerm(libsbml.BIOLOGICAL_QUALIFIER);
      cv1.setBiologicalQualifierType(libsbml.BQB_HAS_PART);
      cv1.addResource("nest");
      cv.addNestedCVTerm(cv1);
      cv1 = null;
      c.addCVTerm(cv);
      cv = null;
      string produced = c.toSBML();
      assertEquals( true, equals(annot,produced) );
    }

  }
}
