/**
 * @file:   DistribFunctionDefinitionPlugin.cpp
 * @brief:  Implementation of the DistribFunctionDefinitionPlugin class
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


#include <sbml/packages/distrib/extension/DistribFunctionDefinitionPlugin.h>


using namespace std;


#ifdef __cplusplus


LIBSBML_CPP_NAMESPACE_BEGIN


/*
 * Creates a new DistribFunctionDefinitionPlugin
 */
DistribFunctionDefinitionPlugin::DistribFunctionDefinitionPlugin(const std::string& uri,  
                                 const std::string& prefix, 
                               DistribPkgNamespaces* distribns) :
	  SBasePlugin(uri, prefix, distribns)
	, mDrawFromDistribution (NULL)
{
}


/*
 * Copy constructor for DistribFunctionDefinitionPlugin.
 */
DistribFunctionDefinitionPlugin::DistribFunctionDefinitionPlugin(const DistribFunctionDefinitionPlugin& orig) :
	  SBasePlugin(orig)
	, mDrawFromDistribution ( orig.mDrawFromDistribution)
{
}


/*
 * Assignment operator for DistribFunctionDefinitionPlugin.
 */
DistribFunctionDefinitionPlugin& 
DistribFunctionDefinitionPlugin::operator=(const DistribFunctionDefinitionPlugin& rhs)
{
	if (&rhs != this)
	{
		this->SBasePlugin::operator=(rhs);
		mDrawFromDistribution = rhs.mDrawFromDistribution;
	}

	return *this;
}


/*
 * Creates and returns a deep copy of this DistribFunctionDefinitionPlugin object.
 */
DistribFunctionDefinitionPlugin* 
DistribFunctionDefinitionPlugin::clone () const
{
	return new DistribFunctionDefinitionPlugin(*this);
}


/*
 * Destructor for DistribFunctionDefinitionPlugin.
 */
DistribFunctionDefinitionPlugin::~DistribFunctionDefinitionPlugin()
{
}


//---------------------------------------------------------------
//
// overridden virtual functions for read/write/check
//
//---------------------------------------------------------------

/*
 * create object
 */
SBase*
DistribFunctionDefinitionPlugin::createObject (XMLInputStream& stream)
{
	SBase* object = NULL; 

	const std::string&      name   = stream.peek().getName(); 
	const XMLNamespaces&    xmlns  = stream.peek().getNamespaces(); 
	const std::string&      prefix = stream.peek().getPrefix(); 

	const std::string& targetPrefix = (xmlns.hasURI(mURI)) ? xmlns.getPrefix(mURI) : mPrefix;

	if (prefix == targetPrefix) 
	{ 
		if (name == "drawFromDistributions" ) 
		{ 
      DISTRIB_CREATE_NS(distribns, getSBMLNamespaces());
      mDrawFromDistribution = new DrawFromDistribution(distribns);
      object = mDrawFromDistribution;
		} 
	} 

	return object; 
}


/*
 * write elements
 */
void
DistribFunctionDefinitionPlugin::writeElements (XMLOutputStream& stream) const
{
	if (mDrawFromDistribution != NULL) 
	{ 
		mDrawFromDistribution->write(stream);
	} 
}


/*
 * Checks if this plugin object has all the required elements.
 */
bool
DistribFunctionDefinitionPlugin::hasRequiredElements () const
{
	bool allPresent = true; 

	// TO DO 

	return allPresent; 
}


//---------------------------------------------------------------
//
// Functions for interacting with the members of the plugin
//
//---------------------------------------------------------------

//---------------------------------------------------------------


/*
 * Set the SBMLDocument.
 */
void
DistribFunctionDefinitionPlugin::setSBMLDocument(SBMLDocument* d)
{
	SBasePlugin::setSBMLDocument(d);

}


/*
 * Connect to parent.
 */
void
DistribFunctionDefinitionPlugin::connectToParent(SBase* sbase)
{
	SBasePlugin::connectToParent(sbase);

}


/*
 * Enables the given package.
 */
void
DistribFunctionDefinitionPlugin::enablePackageInternal(const std::string& pkgURI,
                                   const std::string& pkgPrefix, bool flag)
{
}




LIBSBML_CPP_NAMESPACE_END


#endif /* __cplusplus */


