/**
 * @file:   ExplicitPDF.h
 * @brief:  Implementation of the ExplicitPDF class
 * @author: Generated by autocreate code
 *
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2009-2013 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EBML-EBI), Hinxton, UK
 *
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *
 * Copyright (C) 2002-2005 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ------------------------------------------------------------------------ -->
 */


#ifndef ExplicitPDF_H__
#define ExplicitPDF_H__


#include <sbml/common/extern.h>
#include <sbml/common/sbmlfwd.h>
#include <sbml/packages/distrib/common/distribfwd.h>


#ifdef __cplusplus


#include <string>


#include <sbml/SBase.h>
#include <sbml/ListOf.h>
#include <sbml/packages/distrib/extension/DistribExtension.h>

LIBSBML_CPP_NAMESPACE_BEGIN


class LIBSBML_EXTERN ExplicitPDF : public SBase
{

protected:

	ASTNode*      mMath;


public:

	/**
	 * Creates a new ExplicitPDF with the given level, version, and package version.
	 *
	 * @param level an unsigned int, the SBML Level to assign to this ExplicitPDF
	 *
	 * @param version an unsigned int, the SBML Version to assign to this ExplicitPDF
	 *
	 * @param pkgVersion an unsigned int, the SBML Distrib Version to assign to this ExplicitPDF
	 */
	ExplicitPDF(unsigned int level      = DistribExtension::getDefaultLevel(),
	            unsigned int version    = DistribExtension::getDefaultVersion(),
	            unsigned int pkgVersion = DistribExtension::getDefaultPackageVersion());


	/**
	 * Creates a new ExplicitPDF with the given DistribPkgNamespaces object.
	 *
	 * @param distribns the DistribPkgNamespaces object
	 */
	ExplicitPDF(DistribPkgNamespaces* distribns);


 	/**
	 * Copy constructor for ExplicitPDF.
	 *
	 * @param orig; the ExplicitPDF instance to copy.
	 */
	ExplicitPDF(const ExplicitPDF& orig);


 	/**
	 * Assignment operator for ExplicitPDF.
	 *
	 * @param rhs; the object whose values are used as the basis
	 * of the assignment
	 */
	ExplicitPDF& operator=(const ExplicitPDF& rhs);


 	/**
	 * Creates and returns a deep copy of this ExplicitPDF object.
	 *
	 * @return a (deep) copy of this ExplicitPDF object.
	 */
	virtual ExplicitPDF* clone () const;


 	/**
	 * Destructor for ExplicitPDF.
	 */
	virtual ~ExplicitPDF();


 	/**
	 * Returns the "math" element of this ExplicitPDF.
	 *
	 * @return the "math" element of this ExplicitPDF.
	 */
	virtual const ASTNode* getMath() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * ExplicitPDF's "math" element has been set.
	 *
	 * @return @c true if this ExplicitPDF's "math" element has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetMath() const;


	/**
	 * Sets the "math" element of this ExplicitPDF.
	 *
	 * @param math; ASTNode* determining the value of the "resultLevel" attribute to be set.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setMath(ASTNode* math);


	/**
	 * Unsets the "math" element of this ExplicitPDF.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetMath();


	/**
	 * Returns the XML element name of this object, which for ExplicitPDF, is
	 * always @c "explicitPDF".
	 *
	 * @return the name of this element, i.e. @c "explicitPDF".
	 */
	virtual const std::string& getElementName () const;


	/**
	 * Returns the libSBML type code for this SBML object.
	 * 
	 * @if clike LibSBML attaches an identifying code to every kind of SBML
	 * object.  These are known as <em>SBML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SBMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SBML_. @endif@if java LibSBML attaches an identifying code to every
	 * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSBML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if python LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the Python language interface for libSBML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the C# language interface for libSBML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SBML_. @endif
	 *
	 * @return the SBML type code for this object, or
	 * @link SBMLTypeCode_t#SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getTypeCode () const;


	/**
	 * Predicate returning @c true if all the required attributes
	 * for this ExplicitPDF object have been set.
	 *
	 * @note The required attributes for a ExplicitPDF object are:
	 * @li "math"
	 *
	 * @return a boolean value indicating whether all the required
	 * attributes for this object have been defined.
	 */
	virtual bool hasRequiredAttributes() const;


	/**
	 * Predicate returning @c true if all the required elements
	 * for this ExplicitPDF object have been set.
	 *
	 * @note The required elements for a ExplicitPDF object are:
	 * @li "math"
	 *
	 * @return a boolean value indicating whether all the required
	 * elements for this object have been defined.
	 */
	virtual bool hasRequiredElements() const;


	/** @cond doxygen-libsbml-internal */

	/**
	 * Subclasses should override this method to write out their contained
	 * SBML objects as XML elements.  Be sure to call your parents
	 * implementation of this method as well.
	 */
	virtual void writeElements (XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Accepts the given SBMLVisitor.
	 */
	virtual bool accept (SBMLVisitor& v) const;


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Sets the parent SBMLDocument.
	 */
	virtual void setSBMLDocument (SBMLDocument* d);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Enables/Disables the given package with this element.
	 */
	virtual void enablePackageInternal(const std::string& pkgURI,
	             const std::string& pkgPrefix, bool flag);


	/** @endcond doxygen-libsbml-internal */


protected:

	/** @cond doxygen-libsbml-internal */

	/**
	 * Get the list of expected attributes for this element.
	 */
	virtual void addExpectedAttributes(ExpectedAttributes& attributes);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Read values from the given XMLAttributes set into their specific fields.
	 */
	virtual void readAttributes (const XMLAttributes& attributes,
	                             const ExpectedAttributes& expectedAttributes);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Subclasses should override this method ro read other XML.
	 *
	 * return true if read from stream, false otherwise.
	 */
	virtual bool readOtherXML (XMLInputStream& stream);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Write values of XMLAttributes to the output stream.
	 */
	virtual void writeAttributes (XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */



};



LIBSBML_CPP_NAMESPACE_END

#endif  /*  __cplusplus  */

#ifndef SWIG

LIBSBML_CPP_NAMESPACE_BEGIN
BEGIN_C_DECLS

LIBSBML_EXTERN
ExplicitPDF_t *
ExplicitPDF_create(unsigned int level, unsigned int version,
                   unsigned int pkgVersion);


LIBSBML_EXTERN
void
ExplicitPDF_free(ExplicitPDF_t * epdf);


LIBSBML_EXTERN
ExplicitPDF_t *
ExplicitPDF_clone(ExplicitPDF_t * epdf);


LIBSBML_EXTERN
int
ExplicitPDF_hasRequiredAttributes(ExplicitPDF_t * epdf);


LIBSBML_EXTERN
int
ExplicitPDF_hasRequiredElements(ExplicitPDF_t * epdf);




END_C_DECLS
LIBSBML_CPP_NAMESPACE_END

#endif  /*  !SWIG  */

#endif /*  ExplicitPDF_H__  */

