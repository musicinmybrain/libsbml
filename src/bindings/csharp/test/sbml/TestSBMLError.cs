///  @file    TestSBMLError.cs
///  @brief   SBMLError unit tests, C++ version
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Sarah Keating 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestSBMLError.cpp
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


namespace LibSBMLCSTest.sbml {

  using libsbmlcs;

  using System;

  using System.IO;

  public class TestSBMLError {
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


    public void test_SBMLErrorLog_getErrorWithSeverity()
    {
      SBMLErrorLog log;
      log.add(new SBMLError(ConstraintContainsXMLDecl));
      log.add(new SBMLError(libsbml.EmptyListInReaction));
      log.add(new SBMLError(libsbml.OverdeterminedSystem,2,1));
      log.add(new SBMLError(libsbml.OffsetNoLongerValid,2,2));
      log.add(new SBMLError(libsbml.NoSBOTermsInL1,2,2));
      log.add(new SBMLError(libsbml.DisallowedMathMLEncodingUse,2,2));
      log.add(new SBMLError(libsbml.DisallowedMathMLEncodingUse,1,2));
      log.add(new SBMLError(libsbml.UnknownError,2,4));
      log.add(new SBMLError(70912,2,4));
      SBMLError error = log.getErrorWithSeverity(0,libsbml.LIBSBML_SEV_ERROR);
      assertTrue( error.getErrorId() == ConstraintContainsXMLDecl );
      error = log.getErrorWithSeverity(1,libsbml.LIBSBML_SEV_ERROR);
      assertTrue( error.getErrorId() == libsbml.OffsetNoLongerValid );
      error = log.getErrorWithSeverity(2,libsbml.LIBSBML_SEV_ERROR);
      assertTrue( error.getErrorId() == libsbml.DisallowedMathMLEncodingUse );
      error = log.getErrorWithSeverity(0,libsbml.LIBSBML_SEV_WARNING);
      assertTrue( error.getErrorId() == libsbml.OverdeterminedSystem );
      error = log.getErrorWithSeverity(1,libsbml.LIBSBML_SEV_WARNING);
      assertTrue( error.getErrorId() == libsbml.NoSBOTermsInL1 );
      error = log.getErrorWithSeverity(2,libsbml.LIBSBML_SEV_WARNING);
      assertTrue( error.getErrorId() == 70912 );
      error = log.getErrorWithSeverity(0,libsbml.LIBSBML_SEV_NOT_APPLICABLE);
      assertTrue( error == null );
      error = log.getErrorWithSeverity(0,libsbml.LIBSBML_SEV_FATAL);
      assertTrue( error.getErrorId() == libsbml.UnknownError );
    }

    public void test_SBMLErrorLog_getErrorWithSeverity_XMLError()
    {
      SBMLDocument doc = libsbml.readSBMLFromString("Not actually SBML.");
      SBMLError error = doc.getErrorWithSeverity(0,libsbml.LIBSBML_SEV_ERROR);
      assertTrue( error != null );
      assertTrue( error.getErrorId() < XMLErrorCodesUpperBound );
      error = doc.getError(0);
      assertTrue( error != null );
      assertTrue( error.getErrorId() < XMLErrorCodesUpperBound );
    }

    public void test_SBMLErrorLog_removeAll()
    {
      SBMLErrorLog log;
      log.add(new SBMLError(1234,2,4));
      log.add(new SBMLError(1234,2,4));
      log.add(new SBMLError(1234,2,4));
      log.add(new SBMLError(1234,2,4));
      assertTrue( log.contains(1234) == true );
      log.remove(1234);
      assertTrue( log.contains(1234) == true );
      log.removeAll(1234);
      assertTrue( log.contains(1234) == false );
    }

    public void test_SBMLError_create()
    {
      SBMLError error = new SBMLError();
      assertTrue( error != null );
      error = null;
      error = new SBMLError(ConstraintContainsXMLDecl);
      assertTrue( error.getErrorId() == ConstraintContainsXMLDecl );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR );
      assertTrue( error.getSeverityAsString() ==  "Error"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_SBML );
      assertTrue( error.getCategoryAsString() ==  "General SBML conformance" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.EmptyListInReaction);
      assertTrue( error.getErrorId() == libsbml.EmptyListInReaction );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_NOT_APPLICABLE );
      assertTrue( error.getSeverityAsString() ==  "Not applicable"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_SBML );
      assertTrue( error.getCategoryAsString() ==  "General SBML conformance" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.OverdeterminedSystem,2,1);
      assertTrue( error.getErrorId() == libsbml.OverdeterminedSystem );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_WARNING );
      assertTrue( error.getSeverityAsString() ==  "Warning"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_OVERDETERMINED_MODEL );
      assertTrue( error.getCategoryAsString() ==  "Overdetermined model" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.OffsetNoLongerValid,2,2);
      assertTrue( error.getErrorId() == libsbml.OffsetNoLongerValid );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR );
      assertTrue( error.getSeverityAsString() ==  "Error"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_GENERAL_CONSISTENCY );
      assertTrue( error.getCategoryAsString() ==  "SBML component consistency" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.NoSBOTermsInL1,2,2);
      assertTrue( error.getErrorId() == libsbml.NoSBOTermsInL1 );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_WARNING );
      assertTrue( error.getSeverityAsString() ==  "Warning"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_SBML_L1_COMPAT );
      assertTrue( error.getCategoryAsString() ==  "Translation to SBML L1V2" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.DisallowedMathMLEncodingUse,2,2);
      assertTrue( error.getErrorId() == libsbml.DisallowedMathMLEncodingUse );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR );
      assertTrue( error.getSeverityAsString() ==  "Error"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_MATHML_CONSISTENCY );
      assertTrue( error.getShortMessage() ==  "Use of the MathML 'encoding' attribute is not allowed on this element" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.DisallowedMathMLEncodingUse,1,2);
      assertTrue( error.getErrorId() == libsbml.DisallowedMathMLEncodingUse );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_NOT_APPLICABLE );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_MATHML_CONSISTENCY );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(libsbml.UnknownError,2,4);
      assertTrue( error.getErrorId() == libsbml.UnknownError );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_FATAL );
      assertTrue( error.getSeverityAsString() ==  "Fatal"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_INTERNAL );
      assertTrue( error.getShortMessage() ==  "Encountered unknown internal libSBML error" );
      assertTrue( error.isValid() == true );
      error = null;
      error = new SBMLError(70912,2,4);
      assertTrue( error.getErrorId() == 70912 );
      assertTrue( error.getSeverity() == libsbml.LIBSBML_SEV_WARNING );
      assertTrue( error.getSeverityAsString() ==  "Warning"  );
      assertTrue( error.getCategory() == libsbml.LIBSBML_CAT_INTERNAL );
      assertTrue( error.getShortMessage() ==  "Encountered unknown internal libSBML error" );
      assertTrue( error.isValid() == false );
      error = null;
    }

  }
}
