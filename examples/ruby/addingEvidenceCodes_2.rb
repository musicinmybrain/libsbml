#!/usr/bin/env ruby
#
## 
## \file    addingEvidenceCodes_2.py
## \brief   adds evidence codes to a species in a model
## \author  Sarah Keating
## 
## This file is part of libSBML.  Please visit http://sbml.org for more
## information about SBML, and the latest version of libSBML.
## 

require 'libSBML'

if ARGV.size != 2

  puts "usage: addingEvidenceCodes_2 <input-filename> <output-filename>"
  puts "       Adds controlled vocabulary term to a species"
  exit(2)
end

d = LibSBML::readSBML(ARGV[0])
errors = d.getNumErrors

if (errors > 0)
  print("Read Error(s)\n")
  d.printErrors    
  print("Correct the above and re-run.\n")
  exit(errors);
end

n = d.getModel.getNumSpecies
if (n <= 0)
  print("Model has no species.\n Cannot add CV terms\n")
  exit(0);
end
s = d.getModel.getSpecies(0)

# check that the species has a metaid
# no CVTerms will be added if there is no metaid to reference
# 
if (not s.isSetMetaId)
    s.setMetaId("metaid_0000052")
end
cv1 = LibSBML::CVTerm.new(LibSBML::BIOLOGICAL_QUALIFIER)
cv1.setBiologicalQualifierType(LibSBML::BQB_OCCURS_IN)
cv1.addResource("urn:miriam:obo.go:GO%3A0005764")

s.addCVTerm(cv1)

# now create the additional annotation

# <rdf:Statement> 
#   <rdf:subject rdf:resource="#metaid_0000052"/> 
#   <rdf:predicate rdf:resource="http://biomodels.net/biology-qualifiers/occursIn"/> 
#   <rdf:object rdf:resource="urn:miriam:obo.go:GO%3A0005764"/> 
#   <bqbiol:isDescribedBy> 
#     <rdf:Bag> 
#       <rdf:li rdf:resource="urn:miriam:obo.eco:ECO%3A0000004"/> 
#       <rdf:li rdf:resource="urn:miriam:pubmed:7017716"/> 
#     </rdf:Bag> 
#   </bqbiol:isDescribedBy> 
# </rdf:Statement> 

# attributes
blank_att = LibSBML::XMLAttributes.new

resource_att = LibSBML::XMLAttributes.new

#  create the outer statement node 
statement_triple = LibSBML::XMLTriple.new("Statement",
                                       "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                       "rdf")

statement_token = LibSBML::XMLToken.new(statement_triple, blank_att)

statement = LibSBML::XMLNode.new(statement_token)

# create the subject node
subject_triple = LibSBML::XMLTriple.new("subject",
                                     "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                     "rdf")

resource_att.clear
resource_att.add("rdf:resource", "#" + s.getMetaId)

subject_token = LibSBML::XMLToken.new(subject_triple, resource_att)

subject = LibSBML::XMLNode.new(subject_token)


#create the predicate node 
predicate_triple = LibSBML::XMLTriple.new("predicate",
                                       "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                       "rdf")

resource_att.clear
resource_att.add("rdf:resource",
                 "http://biomodels.net/biology-qualifiers/occursIn")

predicate_token = LibSBML::XMLToken.new(predicate_triple, resource_att)

predicate = LibSBML::XMLNode.new(predicate_token)

#create the object node 
object_triple = LibSBML::XMLTriple.new("object",
                                    "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                    "rdf")

resource_att.clear
resource_att.add("rdf:resource", "urn:miriam:obo.go:GO%3A0005764")

object_token = LibSBML::XMLToken.new(object_triple, resource_att)

object_ = LibSBML::XMLNode.new(object_token)

# create the bqbiol node 
bqbiol_triple = LibSBML::XMLTriple.new("isDescribedBy",
                                    "http://biomodels.net/biology-qualifiers/",
                                    "bqbiol")

bqbiol_token = LibSBML::XMLToken.new(bqbiol_triple, blank_att)

bqbiol = LibSBML::XMLNode.new(bqbiol_token)

# create the bag node 
bag_triple = LibSBML::XMLTriple.new("Bag",
                                 "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                 "rdf")

bag_token = LibSBML::XMLToken.new(bag_triple, blank_att)

bag = LibSBML::XMLNode.new(bag_token)

# create each li node and add to the bag 
li_triple = LibSBML::XMLTriple.new("li",
                                "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                "rdf")

resource_att.clear
resource_att.add("rdf:resource", "urn:miriam:obo.eco:ECO%3A0000004")

li_token = LibSBML::XMLToken.new(li_triple, resource_att)
li_token.setEnd

li = LibSBML::XMLNode.new(li_token)

bag.addChild(li)

resource_att.clear
resource_att.add("rdf:resource", "urn:miriam:pubmed:7017716")
li_token = LibSBML::XMLToken.new(li_triple, resource_att)
li_token.setEnd
li = LibSBML::XMLNode.new(li_token)

bag.addChild(li)

# add the bag to bqbiol 
bqbiol.addChild(bag)

# add subject, predicate, object and bqbiol to statement 
statement.addChild(subject)
statement.addChild(predicate)
statement.addChild(object_)
statement.addChild(bqbiol)


# create a top-level RDF element 
# this will ensure correct merging
# 

xmlns = LibSBML::XMLNamespaces.new
xmlns.add("http://www.w3.org/1999/02/22-rdf-syntax-ns#", "rdf")
xmlns.add("http://purl.org/dc/elements/1.1/", "dc")
xmlns.add("http://purl.org/dc/terms/", "dcterms")
xmlns.add("http://www.w3.org/2001/vcard-rdf/3.0#", "vCard")
xmlns.add("http://biomodels.net/biology-qualifiers/", "bqbiol")
xmlns.add("http://biomodels.net/model-qualifiers/", "bqmodel")

rDF_triple = LibSBML::XMLTriple.new("RDF",
                                 "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                                 "rdf")

rDF_token = LibSBML::XMLToken.new(rDF_triple, blank_att, xmlns)

annotation = LibSBML::XMLNode.new(rDF_token)

# add the staement node to the RDF node 
annotation.addChild(statement)

s.appendAnnotation(annotation)

LibSBML::writeSBML(d, ARGV[1])
exit(errors);
