/**
 * @file:   PredefinedPDF.cpp
 * @brief:  Implementation of the PredefinedPDF class
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


#include <sbml/packages/distrib/sbml/PredefinedPDF.h>


using namespace std;


LIBSBML_CPP_NAMESPACE_BEGIN


/*
 * Creates a new PredefinedPDF with the given level, version, and package version.
 */
PredefinedPDF::PredefinedPDF (unsigned int level, unsigned int version, unsigned int pkgVersion)
	: SBase(level, version)
	 ,mXmlns ("")

{
	// set an SBMLNamespaces derived object of this package
	setSBMLNamespacesAndOwn(new DistribPkgNamespaces(level, version, pkgVersion));

	// connect to child objects
	connectToChild();
}


/*
 * Creates a new PredefinedPDF with the given DistribPkgNamespaces object.
 */
PredefinedPDF::PredefinedPDF (DistribPkgNamespaces* distribns)
	: SBase(distribns)
	 ,mXmlns ("")

{
	// set the element namespace of this object
	setElementNamespace(distribns->getURI());

	// connect to child objects
	connectToChild();

	// load package extensions bound with this object (if any) 
	loadPlugins(distribns);
}


/*
 * Copy constructor for PredefinedPDF.
 */
PredefinedPDF::PredefinedPDF (const PredefinedPDF& orig)
	: SBase(orig)
{
	if (&orig == NULL)
	{
		throw SBMLConstructorException("Null argument to copy constructor");
	}
	else
	{
		mXmlns  = orig.mXmlns;

		// connect to child objects
		connectToChild();
	}
}


/*
 * Assignment for PredefinedPDF.
 */
PredefinedPDF&
PredefinedPDF::operator=(const PredefinedPDF& rhs)
{
	if (&rhs == NULL)
	{
		throw SBMLConstructorException("Null argument to assignment");
	}
	else if (&rhs != this)
	{
		SBase::operator=(rhs);
		mXmlns  = rhs.mXmlns;

		// connect to child objects
		connectToChild();
	}
	return *this;
}


/*
 * Clone for PredefinedPDF.
 */
PredefinedPDF*
PredefinedPDF::clone () const
{
	return new PredefinedPDF(*this);
}


/*
 * Destructor for PredefinedPDF.
 */
PredefinedPDF::~PredefinedPDF ()
{
}


/*
 * Returns the value of the "xmlns" attribute of this PredefinedPDF.
 */
const std::string&
PredefinedPDF::getXmlns() const
{
	return mXmlns;
}


/*
 * Returns true/false if xmlns is set.
 */
bool
PredefinedPDF::isSetXmlns() const
{
	return (mXmlns.empty() == false);
}


/*
 * Sets xmlns and returns value indicating success.
 */
int
PredefinedPDF::setXmlns(const std::string& xmlns)
{
	if (&(xmlns) == NULL)
	{
		return LIBSBML_INVALID_ATTRIBUTE_VALUE;
	}
	else
	{
		mXmlns = xmlns;
		return LIBSBML_OPERATION_SUCCESS;
	}
}


/*
 * Unsets xmlns and returns value indicating success.
 */
int
PredefinedPDF::unsetXmlns()
{
	mXmlns.erase();

	if (mXmlns.empty() == true)
	{
		return LIBSBML_OPERATION_SUCCESS;
	}
	else
	{
		return LIBSBML_OPERATION_FAILED;
	}
}


/*
 * Returns the XML element name of this object
 */
const std::string&
PredefinedPDF::getElementName () const
{
	static const string name = "predefinedPDF";
	return name;
}


/*
 * Returns the libSBML type code for this SBML object.
 */
int
PredefinedPDF::getTypeCode () const
{
	return SBML_DISTRIB_PREDEFINED_PDF;
}


/*
 * check if all the required attributes are set
 */
bool
PredefinedPDF::hasRequiredAttributes () const
{
	bool allPresent = true;

	if (isSetXmlns() == false)
		allPresent = false;

	return allPresent;
}


/*
 * check if all the required elements are set
 */
bool
PredefinedPDF::hasRequiredElements () const
{
	bool allPresent = true;

	return allPresent;
}


	/** @cond doxygen-libsbml-internal */

/*
 * write contained elements
 */
void
PredefinedPDF::writeElements (XMLOutputStream& stream) const
{
	SBase::writeElements(stream);
	SBase::writeExtensionElements(stream);
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Accepts the given SBMLVisitor.
 */
bool
PredefinedPDF::accept (SBMLVisitor& v) const
{
	return false;

}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Sets the parent SBMLDocument.
 */
void
PredefinedPDF::setSBMLDocument (SBMLDocument* d)
{
	SBase::setSBMLDocument(d);
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
	 * Connects to child elements.
 */
void
PredefinedPDF::connectToChild()
{
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Enables/Disables the given package with this element.
 */
void
PredefinedPDF::enablePackageInternal(const std::string& pkgURI,
             const std::string& pkgPrefix, bool flag)
{
	SBase::enablePackageInternal(pkgURI, pkgPrefix, flag);
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * creates object.
 */
SBase*
PredefinedPDF::createObject(XMLInputStream& stream)
{
	const string& name = stream.peek().getName();
	SBase* object = NULL;


	return object;
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Get the list of expected attributes for this element.
 */
void
PredefinedPDF::addExpectedAttributes(ExpectedAttributes& attributes)
{
	SBase::addExpectedAttributes(attributes);

	attributes.add("xmlns");
}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Read values from the given XMLAttributes set into their specific fields.
 */
void
PredefinedPDF::readAttributes (const XMLAttributes& attributes,
                             const ExpectedAttributes& expectedAttributes)
{
	SBase::readAttributes(attributes, expectedAttributes);

	bool assigned = false;

	//
	// xmlns string   ( use = "required" )
	//
	assigned = attributes.readInto("xmlns", mXmlns, getErrorLog(), true);

	if (assigned == true)
	{
		// check string is not empty

		if (mXmlns.empty() == true)
		{
			logEmptyString(mXmlns, getLevel(), getVersion(), "<PredefinedPDF>");
		}
	}

}


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

/*
 * Write values of XMLAttributes to the output stream.
 */
	void
PredefinedPDF::writeAttributes (XMLOutputStream& stream) const
{
	SBase::writeAttributes(stream);

	if (isSetXmlns() == true)
		stream.writeAttribute("xmlns", getPrefix(), mXmlns);

	SBase::writeExtensionAttributes(stream);

}


	/** @endcond doxygen-libsbml-internal */


/**
 * write comments
 */
LIBSBML_EXTERN
PredefinedPDF_t *
PredefinedPDF_create(unsigned int level, unsigned int version,
                     unsigned int pkgVersion)
{
	return new PredefinedPDF(level, version, pkgVersion);
}


/**
 * write comments
 */
LIBSBML_EXTERN
void
PredefinedPDF_free(PredefinedPDF_t * ppdf)
{
	if (ppdf != NULL)
		delete ppdf;
}


/**
 * write comments
 */
LIBSBML_EXTERN
PredefinedPDF_t *
PredefinedPDF_clone(PredefinedPDF_t * ppdf)
{
	if (ppdf != NULL)
	{
		return static_cast<PredefinedPDF_t*>(ppdf->clone());
	}
	else
	{
		return NULL;
	}
}


/**
 * write comments
 */
LIBSBML_EXTERN
char *
PredefinedPDF_getXmlns(PredefinedPDF_t * ppdf)
{
	if (ppdf == NULL)
		return NULL;

	return ppdf->getXmlns().empty() ? NULL : safe_strdup(ppdf->getXmlns().c_str());
}


/**
 * write comments
 */
LIBSBML_EXTERN
int
PredefinedPDF_isSetXmlns(PredefinedPDF_t * ppdf)
{
	return (ppdf != NULL) ? static_cast<int>(ppdf->isSetXmlns()) : 0;
}


/**
 * write comments
 */
LIBSBML_EXTERN
int
PredefinedPDF_setXmlns(PredefinedPDF_t * ppdf, const char * xmlns)
{
	return (ppdf != NULL) ? ppdf->setXmlns(xmlns) : LIBSBML_INVALID_OBJECT;
}


/**
 * write comments
 */
LIBSBML_EXTERN
int
PredefinedPDF_unsetXmlns(PredefinedPDF_t * ppdf)
{
	return (ppdf != NULL) ? ppdf->unsetXmlns() : LIBSBML_INVALID_OBJECT;
}


/**
 * write comments
 */
LIBSBML_EXTERN
int
PredefinedPDF_hasRequiredAttributes(PredefinedPDF_t * ppdf)
{
	return (ppdf != NULL) ? static_cast<int>(ppdf->hasRequiredAttributes()) : 0;
}




LIBSBML_CPP_NAMESPACE_END


